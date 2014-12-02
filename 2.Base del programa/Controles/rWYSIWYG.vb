Imports Recompila.Helper
Imports System.Net
Imports System.IO
Imports System.Runtime.InteropServices

Public Class rWYSIWYG

#Region " API WINDOWS "
    <DllImport("OLE32.DLL", EntryPoint:="CreateStreamOnHGlobal")> _
    Public Shared Function CreateStreamOnHGlobal(ByVal hGlobalMemHandle As Integer, ByVal fDeleteOnRelease As Boolean, ByRef pOutStm As ComTypes.IStream) As Integer
    End Function

    <ComImport(), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0000010c-0000-0000-C000-000000000046")> _
    Public Interface IPersist
        Sub GetClassID(ByRef pClassID As Guid)
    End Interface

    <ComImport(), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("7FD52380-4E07-101B-AE2D-08002B2EC713")> _
    Public Interface IPersistStreamInit
        Inherits IPersist
        Shadows Sub GetClassID(ByRef pClassID As Guid)
        <PreserveSig()> _
        Function IsDirty() As Integer
        Sub Load(<[In]()> ByVal pStm As ComTypes.IStream)
        Sub Save(<[In]()> ByVal pStm As ComTypes.IStream, <[In](), MarshalAs(UnmanagedType.Bool)> ByVal fClearDirty As Boolean)
        Sub GetSizeMax(ByRef pcbSize As Long)
        Sub InitNew()
    End Interface
#End Region

#Region " DECLARACIONES "
    ''' <summary>
    ''' Documento HTML con el que se está trabajando, permite acceder a 
    ''' los eventos que se realicen sobre el (Click, KeyDown...)
    ''' </summary>
    Private WithEvents iHTMLDoc As HtmlDocument

    ''' <summary>
    ''' Flag para controlar si el documento se está sincronizando y evitar 
    ''' ejecuciones simultaneas o repetidas mientras se están aplicando formatos
    ''' o ejecutando comandos
    ''' </summary>
    Private iSincronizando As Boolean = False

    ''' <summary>
    ''' HTML que se tiene que cargar en el documento cuando este se limpia o cargar por primera vez
    ''' </summary>
    Private iPaginaBlanco As String = "<html><body id=""elBody""><div id=""elDivEditable""></div></body></html>"
#End Region

#Region " PROPIEDADES "
    ''' <summary>
    ''' Documento con el que se está trabajando
    ''' </summary>
    Public Property Documento As Object = Nothing

    ''' <summary>
    ''' Determina si el documento está protegido contra escritura o no
    ''' </summary>
    Public Property [ReadOnly] As Boolean
        Get
            Return iReadOnly
        End Get
        Set(ByVal value As Boolean)
            iReadOnly = value
            If Documento IsNot Nothing Then
                Documento.designMode = IIf(iReadOnly, "Off", "On")
            End If
        End Set
    End Property
    Private iReadOnly As Boolean = False

    ''' <summary>
    ''' Obtiene el texto del documeto
    ''' </summary>
    Public Overrides Property Text() As String
        Get
            If Documento Is Nothing OrElse Documento.body Is Nothing Then
                Return ""
            Else
                If HTMLEditor.InvokeRequired Then
                    If ConvertirImagenesABase64 Then HTMLEditor.Invoke(Sub() codificarImagenes())
                    Return HTMLEditor.Invoke(Function() HTMLEditor.DocumentText)
                Else
                    If ConvertirImagenesABase64 Then codificarImagenes()
                    Return HTMLEditor.DocumentText
                End If
            End If
        End Get
        Set(ByVal value As String)
            If Not HTMLEditor.Document Is Nothing Then
                eliminarPreguntaGuardado(HTMLEditor)

                If value <> "" Then
                    HTMLEditor.Document.OpenNew(False).Write(value)
                Else
                    HTMLEditor.Document.OpenNew(False).Write(iPaginaBlanco)
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' Determina si el documetno está vacío
    ''' </summary>
    Public ReadOnly Property isEmpty() As Boolean
        Get
            Return String.Equals(HTMLEditor.DocumentText, iPaginaBlanco, StringComparison.OrdinalIgnoreCase)
        End Get
    End Property

    ''' <summary>
    ''' Determina si se tienen que convertir las imágenes del documento a BASE64
    ''' </summary>
    Public Property ConvertirImagenesABase64 As Boolean
        Get
            Return iConvertirImagenesABase64
        End Get
        Set(ByVal value As Boolean)
            iConvertirImagenesABase64 = value
        End Set
    End Property
    Private iConvertirImagenesABase64 As Boolean = True

    ''' <summary>
    ''' Muestra o oculta la barra general de opicones
    ''' </summary>
    Public Property mostrarBarraGeneral As Boolean
        Get
            Return iMostrarBarraGeneral
        End Get
        Set(value As Boolean)
            iMostrarBarraGeneral = value
            tsGeneral.Visible = iMostrarBarraGeneral
        End Set
    End Property
    Private iMostrarBarraGeneral As Boolean = True

    ''' <summary>
    ''' Muestra o oculta la barra para la insercción de objetos
    ''' </summary>
    Public Property mostrarBarraObjetos As Boolean
        Get
            Return iMostrarBarraObjetos
        End Get
        Set(value As Boolean)
            iMostrarBarraObjetos = value
            tsObjetos.Visible = iMostrarBarraObjetos
        End Set
    End Property
    Private iMostrarBarraObjetos As Boolean = True

    ''' <summary>
    ''' Muestra o oculta la barra para dar formato al texto
    ''' </summary>
    Public Property mostrarBarraFormato As Boolean
        Get
            Return iMostrarBarraFormato
        End Get
        Set(value As Boolean)
            iMostrarBarraFormato = value
            tsFormato.Visible = iMostrarBarraFormato
        End Set
    End Property
    Private iMostrarBarraFormato As Boolean = True

    ''' <summary>
    ''' Muestra o oculta el botón que permite guardar el documento
    ''' </summary>
    Public Property mostrarBotonGuardar As Boolean
        Get
            Return iMostrarBotonGuardar
        End Get
        Set(value As Boolean)
            iMostrarBotonGuardar = value
            btnGuardar.Visible = iMostrarBotonGuardar
        End Set
    End Property
    Private iMostrarBotonGuardar As Boolean = True

    ''' <summary>
    ''' Muestra o oculta el botón que permite imprimir el documento
    ''' </summary>
    Public Property mostrarBotonImprimir As Boolean
        Get
            Return iMostrarBotonImprimir
        End Get
        Set(value As Boolean)
            iMostrarBotonImprimir = value
            btnImprimir.Visible = iMostrarBotonImprimir
        End Set
    End Property
    Private iMostrarBotonImprimir As Boolean = True

    ''' <summary>
    ''' Muestra o oculta el botón que permite insertar imágenes en el documento
    ''' </summary>
    Public Property mostrarBotonInsertarImagen As Boolean
        Get
            Return iMostrarBotonInsertarImagen
        End Get
        Set(value As Boolean)
            iMostrarBotonInsertarImagen = value
            btnImagen.Visible = iMostrarBotonInsertarImagen
        End Set
    End Property
    Private iMostrarBotonInsertarImagen As Boolean
#End Region

#Region " EVENTOS "
    Public Shadows Event GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private Sub HTML_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLEditor.GotFocus
        RaiseEvent GotFocus(Me, e)
    End Sub

    Public Shadows Event LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private Sub HTML_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLEditor.LostFocus
        RaiseEvent LostFocus(Me, e)
    End Sub
#End Region

#Region " CONSTRUCTORES "
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Se crea un documento temporal para cargar el documento en blanco
        Dim rutaTemporal As String = Path.GetTempFileName & ".html"
        Dim elEscritor As New StreamWriter(rutaTemporal, False)
        elEscritor.Write(iPaginaBlanco)
        elEscritor.Close()

        ' Se carga el documento en blanco
        HTMLEditor.Navigate(rutaTemporal)
        System.Windows.Forms.Application.DoEvents()

        ' Se elimna el documento temporal utilizado para la carga
        Try
            IO.File.Delete(rutaTemporal)
        Catch ex As Exception
        End Try

        ' Iniciar el modo de edición en el editor
        HTMLEditor.IsWebBrowserContextMenuEnabled = False

        ' Se le indica al sistema que se va controlar el dibuajado de los elementos del combo
        cmbFuente.ComboBox.DrawMode = DrawMode.OwnerDrawVariable
        AddHandler cmbFuente.ComboBox.DrawItem, AddressOf DibujarFuente
        CargarFuentesSistema()

        ' Se selecciona la fuente y el tamaño predeterminado
        If cmbFuente.ComboBox.FindString("Verdana") > -1 Then cmbFuente.SelectedIndex = cmbFuente.ComboBox.FindString("Verdana")
        cmbTamanho.ComboBox.SelectedIndex = 2

        ' Se inician los timers de procesado de comandos en el editor
        tmrReloj.Enabled = True
        tmrReloj.Start()
    End Sub
#End Region

#Region " METODOS AUXILIARES "
    ''' <summary>
    ''' Obtiene todos los controles ToolStripItem de un determinado control
    ''' </summary>
    ''' <param name="eControl">Control del que se quiere obtener los controles hijos</param>
    ''' <returns>Listado con todos los controles hijos</returns>
    Private Function ObtenerControles(ByRef eControl As Control) As List(Of ToolStripItem)
        Dim Resultado As New List(Of ToolStripItem)

        For Each Hijo As Control In eControl.Controls
            If TypeOf (Hijo) Is ToolStrip AndAlso DirectCast(Hijo, ToolStrip).Items.Count > 0 Then
                For Each Item In DirectCast(Hijo, ToolStrip).Items
                    Resultado.Add(Item)
                Next
            ElseIf Hijo.HasChildren Then
                Resultado.AddRange(ObtenerControles(Hijo))
            End If
        Next

        Return Resultado
    End Function

    ''' <summary>
    ''' Evento de finalización de carga del documento HTML
    ''' </summary>
    Private Sub HTMLEditor_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles HTMLEditor.DocumentCompleted
        ' Se añaden los manejadores para los eventos cuando se completa la carga del documento
        If HTMLEditor.Document IsNot Nothing Then
            iHTMLDoc = HTMLEditor.Document
            Documento = HTMLEditor.ActiveXInstance.Document
            If Documento IsNot Nothing Then
                If Not [ReadOnly] Then Documento.designMode = "On"
            End If
        End If
    End Sub

    ''' <summary>
    ''' Obtiene todas las imagenes del documento y las convierte a Base 64
    ''' </summary>
    Private Sub codificarImagenes()
        If Documento.images IsNot Nothing AndAlso Documento.images.length > 0 Then
            For Each Imagen In Documento.images
                If Not Imagen.src.ToLower.StartsWith("data:") Then
                    Dim laImagen As Image = Imagenes.obtenerImagenHTTP2Image(Imagen.src)
                    If laImagen IsNot Nothing Then
                        Imagen.src = "data:image/png;base64," & Imagenes.imagen2Base64(laImagen, System.Drawing.Imaging.ImageFormat.Png)
                    End If
                End If
            Next
        End If
    End Sub

    Friend Shared Sub eliminarPreguntaGuardado(ByVal WBB As WebBrowser)
        Dim p As IPersistStreamInit = DirectCast(WBB.ActiveXInstance, IPersistStreamInit)
        Dim data As ComTypes.IStream = Nothing
        CreateStreamOnHGlobal(0, True, data)

        p.Save(data, True)
    End Sub
#End Region

#Region " COMANDOS "
    ''' <summary>
    ''' Envia el comando al control
    ''' </summary>
    Private Sub AplicarOpcion(ByVal sender As Object, ByVal e As EventArgs) Handles btnRedo.Click, btnDeshacer.Click, btnPegar.Click, tsbCortar.Click, btnCopiar.Click, btnFormatoSubrayado.Click, btnFormatoNegrita.Click, btnFormatoCursiva.Click, btnTabulacionDerecha.Click, btnFormatoTachado.Click, btnFormatoAlineacionJustificar.Click, btnFormatoAlinearIzquierda.Click, btnFormatoAlineacionDerecha.Click, btnFormatoAlineacionCentro.Click, btnImprimir.Click, btnGuardar.Click, btnFormatoListaOrdenada.Click, btnEliminar.Click, btnLinea.Click, btnEnlace.Click, btnTabulacionIzquierda.Click, btnImagen.Click
        If iSincronizando OrElse DirectCast(sender, ToolStripItem).Tag Is Nothing Then Exit Sub

        tmrReloj.Enabled = False
        Try
            HTMLEditor.Document.ExecCommand(DirectCast(sender, ToolStripItem).Tag, True, Nothing)
        Catch
        End Try
        tmrReloj.Enabled = True
    End Sub

    ''' <summary>
    ''' Realiza un cambio en el color
    ''' </summary>
    Private Sub CambiarColor(ByVal sender As Object, ByVal e As EventArgs) Handles btnColor.Click
        tmrReloj.Enabled = False

        Try
            Dim ventanaSeleccionColor As New ColorDialog
            With ventanaSeleccionColor
                .AllowFullOpen = True
                .AnyColor = True
                Dim valor As Object = Documento.queryCommandValue("ForeColor")

                If valor IsNot Nothing AndAlso Not IsDBNull(valor) Then
                    Dim Intermidiate() As Byte = BitConverter.GetBytes(valor)
                    Dim IntermidiateByte As Byte = Intermidiate(0)
                    Intermidiate(0) = Intermidiate(2)
                    Intermidiate(2) = IntermidiateByte
                    .Color = Color.FromArgb(BitConverter.ToInt32(Intermidiate, 0))
                End If

                If .ShowDialog = DialogResult.OK Then
                    Dim aux As String = Hex(.Color.ToArgb()).Substring(2)
                    HTMLEditor.Document.ExecCommand("ForeColor", True, "#" & Hex(.Color.ToArgb()).Substring(2))
                End If
            End With
        Catch ex As System.Exception
        End Try

        tmrReloj.Enabled = True
    End Sub

    ''' <summary>
    ''' Verifica los comandos activos en la selección actual
    ''' </summary>
    Private Sub VerficarComandos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReloj.Tick
        iSincronizando = True

        For Each Ctrl As ToolStripItem In ObtenerControles(Me)
            Try
                If TypeOf (Ctrl) Is ToolStripButton AndAlso DirectCast(Ctrl, ToolStripButton).CheckOnClick AndAlso Not String.IsNullOrEmpty(Ctrl.Tag) Then ' Botones tipo "check"
                    If Documento.queryCommandState(Ctrl.Tag) Then
                        If DirectCast(Ctrl, ToolStripButton).Checked <> CheckState.Checked Then
                            DirectCast(Ctrl, ToolStripButton).Checked = True
                        End If
                    Else
                        If DirectCast(Ctrl, ToolStripButton).CheckState = CheckState.Checked Then
                            DirectCast(Ctrl, ToolStripButton).Checked = False
                        End If
                    End If
                End If
            Catch
            End Try
        Next

        iSincronizando = False
    End Sub
#End Region

#Region " FUENTES "
    ''' <summary>
    ''' Cambia la fuente que se utiliza actualmente en el control
    ''' </summary>
    Private Sub CambioFuente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTamanho.SelectedIndexChanged, cmbFuente.SelectedIndexChanged
        If iSincronizando OrElse (Not IsHandleCreated OrElse DesignMode) OrElse DirectCast(sender, ToolStripItem).Tag Is Nothing Then Exit Sub

        tmrReloj.Enabled = False
        HTMLEditor.Document.ExecCommand(DirectCast(sender, ToolStripItem).Tag, True, DirectCast(sender, ToolStripItem).Text)
        tmrReloj.Enabled = True
    End Sub

    ''' <summary>
    ''' Obtiene las fuentes instaladas en el sistema y las carga en el combobox
    ''' </summary>
    Private Sub CargarFuentesSistema()
        ' Se eliminan los datos previos si estos existían
        If cmbFuente.Items.Count > 0 Then
            For i As Integer = 0 To cmbFuente.ComboBox.Items.Count - 1
                CType(cmbFuente.ComboBox.Items(i), Font).Dispose()
            Next

            cmbFuente.ComboBox.Items.Clear()
        End If

        ' Se obtiene el listado de fuentes disponibles en el sistema
        For Each fuente As FontFamily In FontFamily.Families
            Dim f As Font = Nothing

            ' Se crean las fuentas en función de los estilos disponibles
            If (fuente.IsStyleAvailable(FontStyle.Regular)) Then
                f = New Font(fuente.Name, cmbFuente.ComboBox.Font.Size)
            ElseIf (fuente.IsStyleAvailable(FontStyle.Bold)) Then
                f = New Font(fuente.Name, cmbFuente.ComboBox.Font.Size, FontStyle.Bold)
            ElseIf (fuente.IsStyleAvailable(FontStyle.Italic)) Then
                f = New Font(fuente.Name, cmbFuente.ComboBox.Font.Size, FontStyle.Italic)
            ElseIf (fuente.IsStyleAvailable(FontStyle.Underline)) Then
                f = New Font(fuente.Name, cmbFuente.ComboBox.Font.Size, FontStyle.Underline)
            End If

            ' Se añade la fuente al combo
            If f IsNot Nothing AndAlso Not cmbFuente.ComboBox.Items.Contains(f) Then cmbFuente.ComboBox.Items.Add(f)
        Next

        ' Se le indica al combo cual es la propiedad que se debe mostrar
        cmbFuente.ComboBox.DisplayMember = "FontFamily.Name"
    End Sub

    ''' <summary>
    ''' Se dibuja cada fuente de forma independiente
    ''' </summary>
    ''' <param name="sender">Objeto que desencadena el evento. Por defecto es el combobox </param>
    ''' <param name="e">Parámetros de la llamada a la función</param>
    Private Sub DibujarFuente(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        ' Si el índice del elemento no es válido no se puede dibujar
        If ((e.Index = -1) OrElse (e.Index >= cmbFuente.ComboBox.Items.Count)) Then Exit Sub

        ' Se dibuja el fondo del elemento
        e.DrawBackground()

        ' Se comprueba si hay que dibujar el cuadro de selección y si es así se dibuja
        If (e.State = DrawItemState.Focus) Then e.DrawFocusRectangle()

        ' Se crean los objetos necesarios para el dibujado de la fuenta y se dibuja
        Dim pincel As Brush = Nothing
        Try
            pincel = New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(CType(cmbFuente.ComboBox.Items(e.Index), Font).Name, CType(cmbFuente.ComboBox.Items(e.Index), Font), pincel, e.Bounds)
        Finally
            pincel.Dispose()
            pincel = Nothing
        End Try
    End Sub
#End Region

#Region " METODOS PUBLICOS "
    ''' <summary>
    ''' Limpia el documento 
    ''' </summary>
    Public Sub Clear()
        Text = String.Empty
    End Sub

    ''' <summary>
    ''' Inserta el código html en el documento
    ''' </summary>
    ''' <param name="eTexto"></param>
    Public Sub PegarHTML(ByVal eTexto As String)
        If Documento Is Nothing Then Exit Sub

        Dim Seleccion As Object = Documento.selection
        If Seleccion IsNot Nothing Then
            Dim rango As Object = Seleccion.createRange()
            If rango IsNot Nothing Then
                rango.pasteHTML(eTexto)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Asigna un menu contextual al documento
    ''' </summary>
    ''' <param name="eMenu">Menú contextual que se tiene que asginar</param>
    Public Sub asignarMenu(ByRef eMenu As ContextMenuStrip)
        HTMLEditor.ContextMenuStrip = eMenu
    End Sub
#End Region
End Class
