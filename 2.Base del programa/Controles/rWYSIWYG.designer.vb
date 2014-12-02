<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rWYSIWYG
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tsGeneral = New System.Windows.Forms.ToolStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsSeparadorGeneral1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCortar = New System.Windows.Forms.ToolStripButton()
        Me.btnCopiar = New System.Windows.Forms.ToolStripButton()
        Me.btnPegar = New System.Windows.Forms.ToolStripButton()
        Me.tsSeparadorGeneral2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDeshacer = New System.Windows.Forms.ToolStripButton()
        Me.btnRedo = New System.Windows.Forms.ToolStripButton()
        Me.tsFormato = New System.Windows.Forms.ToolStrip()
        Me.cmbTamanho = New System.Windows.Forms.ToolStripComboBox()
        Me.btnColor = New System.Windows.Forms.ToolStripButton()
        Me.tsSeparadorFormato1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFormatoNegrita = New System.Windows.Forms.ToolStripButton()
        Me.btnFormatoCursiva = New System.Windows.Forms.ToolStripButton()
        Me.btnFormatoSubrayado = New System.Windows.Forms.ToolStripButton()
        Me.btnFormatoTachado = New System.Windows.Forms.ToolStripButton()
        Me.tsSeparadorFormato2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFormatoAlinearIzquierda = New System.Windows.Forms.ToolStripButton()
        Me.btnFormatoAlineacionCentro = New System.Windows.Forms.ToolStripButton()
        Me.btnFormatoAlineacionDerecha = New System.Windows.Forms.ToolStripButton()
        Me.btnFormatoAlineacionJustificar = New System.Windows.Forms.ToolStripButton()
        Me.tsSperadorFormato3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFormatoListaOrdenada = New System.Windows.Forms.ToolStripButton()
        Me.tsObjetos = New System.Windows.Forms.ToolStrip()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnEnlace = New System.Windows.Forms.ToolStripButton()
        Me.btnImagen = New System.Windows.Forms.ToolStripButton()
        Me.btnLinea = New System.Windows.Forms.ToolStripButton()
        Me.tsSeparadorObjetos1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTabulacionIzquierda = New System.Windows.Forms.ToolStripButton()
        Me.btnTabulacionDerecha = New System.Windows.Forms.ToolStripButton()
        Me.tmrReloj = New System.Windows.Forms.Timer(Me.components)
        Me.HTMLEditor = New System.Windows.Forms.WebBrowser()
        Me.ttpInformación = New System.Windows.Forms.ToolTip(Me.components)
        Me.tblEditor = New System.Windows.Forms.TableLayoutPanel()
        Me.krgEditor = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.cmbFuente = New System.Windows.Forms.ToolStripComboBox()
        Me.tsGeneral.SuspendLayout()
        Me.tsFormato.SuspendLayout()
        Me.tsObjetos.SuspendLayout()
        Me.tblEditor.SuspendLayout()
        CType(Me.krgEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.krgEditor.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.krgEditor.Panel.SuspendLayout()
        Me.krgEditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsGeneral
        '
        Me.tsGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsGeneral.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.btnImprimir, Me.tsSeparadorGeneral1, Me.tsbCortar, Me.btnCopiar, Me.btnPegar, Me.tsSeparadorGeneral2, Me.btnDeshacer, Me.btnRedo})
        Me.tsGeneral.Location = New System.Drawing.Point(0, 0)
        Me.tsGeneral.Name = "tsGeneral"
        Me.tsGeneral.Size = New System.Drawing.Size(185, 25)
        Me.tsGeneral.TabIndex = 12
        Me.tsGeneral.Text = "ToolStrip1"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.save_16_blanco_255
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.btnGuardar.Tag = "SaveAs"
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.ToolTipText = "Guardar una copia"
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.printer_16_blanco_255
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(23, 22)
        Me.btnImprimir.Tag = "Print"
        Me.btnImprimir.Text = "&Imprimir"
        '
        'tsSeparadorGeneral1
        '
        Me.tsSeparadorGeneral1.Name = "tsSeparadorGeneral1"
        Me.tsSeparadorGeneral1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCortar
        '
        Me.tsbCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCortar.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.cut_blanco_16
        Me.tsbCortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCortar.Name = "tsbCortar"
        Me.tsbCortar.Size = New System.Drawing.Size(23, 22)
        Me.tsbCortar.Tag = "Cut"
        Me.tsbCortar.Text = "Cort&ar"
        '
        'btnCopiar
        '
        Me.btnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopiar.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.page_copy_16_blanco_255
        Me.btnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(23, 22)
        Me.btnCopiar.Tag = "Copy"
        Me.btnCopiar.Text = "&Copiar"
        '
        'btnPegar
        '
        Me.btnPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPegar.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.clipboard_paste_16_blanco_255
        Me.btnPegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPegar.Name = "btnPegar"
        Me.btnPegar.Size = New System.Drawing.Size(23, 22)
        Me.btnPegar.Tag = "Paste"
        Me.btnPegar.Text = "&Pegar"
        '
        'tsSeparadorGeneral2
        '
        Me.tsSeparadorGeneral2.Name = "tsSeparadorGeneral2"
        Me.tsSeparadorGeneral2.Size = New System.Drawing.Size(6, 25)
        '
        'btnDeshacer
        '
        Me.btnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeshacer.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.undo_curve_16_blanco_255
        Me.btnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(23, 22)
        Me.btnDeshacer.Tag = "Undo"
        Me.btnDeshacer.Text = "ToolStripButton1"
        Me.btnDeshacer.ToolTipText = "Deshacer"
        '
        'btnRedo
        '
        Me.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRedo.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.redo_curve_16_blanco_255
        Me.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(23, 22)
        Me.btnRedo.Tag = "Redo"
        Me.btnRedo.Text = "ToolStripButton2"
        Me.btnRedo.ToolTipText = "Rehacer"
        '
        'tsFormato
        '
        Me.tsFormato.AutoSize = False
        Me.tblEditor.SetColumnSpan(Me.tsFormato, 2)
        Me.tsFormato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsFormato.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsFormato.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbFuente, Me.cmbTamanho, Me.btnColor, Me.tsSeparadorFormato1, Me.btnFormatoNegrita, Me.btnFormatoCursiva, Me.btnFormatoSubrayado, Me.btnFormatoTachado, Me.tsSeparadorFormato2, Me.btnFormatoAlinearIzquierda, Me.btnFormatoAlineacionCentro, Me.btnFormatoAlineacionDerecha, Me.btnFormatoAlineacionJustificar, Me.tsSperadorFormato3, Me.btnFormatoListaOrdenada})
        Me.tsFormato.Location = New System.Drawing.Point(0, 25)
        Me.tsFormato.Name = "tsFormato"
        Me.tsFormato.Size = New System.Drawing.Size(553, 25)
        Me.tsFormato.TabIndex = 15
        Me.tsFormato.Text = "ToolStrip1"
        '
        'cmbTamanho
        '
        Me.cmbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTamanho.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.cmbTamanho.Name = "cmbTamanho"
        Me.cmbTamanho.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.cmbTamanho.Size = New System.Drawing.Size(75, 25)
        Me.cmbTamanho.Tag = "FontSize"
        Me.cmbTamanho.ToolTipText = "Tamaño del texto"
        '
        'btnColor
        '
        Me.btnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnColor.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.draw_brush_16_blanco_255
        Me.btnColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(23, 22)
        Me.btnColor.Text = "&Color"
        '
        'tsSeparadorFormato1
        '
        Me.tsSeparadorFormato1.Name = "tsSeparadorFormato1"
        Me.tsSeparadorFormato1.Size = New System.Drawing.Size(6, 25)
        '
        'btnFormatoNegrita
        '
        Me.btnFormatoNegrita.CheckOnClick = True
        Me.btnFormatoNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoNegrita.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_bold_16_blanco_255
        Me.btnFormatoNegrita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoNegrita.Name = "btnFormatoNegrita"
        Me.btnFormatoNegrita.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoNegrita.Tag = "Bold"
        Me.btnFormatoNegrita.Text = "&Negrita"
        Me.btnFormatoNegrita.ToolTipText = "Negrita"
        '
        'btnFormatoCursiva
        '
        Me.btnFormatoCursiva.CheckOnClick = True
        Me.btnFormatoCursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoCursiva.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_italic_16_blanco_255
        Me.btnFormatoCursiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoCursiva.Name = "btnFormatoCursiva"
        Me.btnFormatoCursiva.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoCursiva.Tag = "Italic"
        Me.btnFormatoCursiva.Text = "Curs&iva"
        Me.btnFormatoCursiva.ToolTipText = "Cursiva"
        '
        'btnFormatoSubrayado
        '
        Me.btnFormatoSubrayado.CheckOnClick = True
        Me.btnFormatoSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoSubrayado.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_underline_16_blanco_255
        Me.btnFormatoSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoSubrayado.Name = "btnFormatoSubrayado"
        Me.btnFormatoSubrayado.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoSubrayado.Tag = "Underline"
        Me.btnFormatoSubrayado.Text = "S&ubrayado"
        Me.btnFormatoSubrayado.ToolTipText = "Subrayado"
        '
        'btnFormatoTachado
        '
        Me.btnFormatoTachado.CheckOnClick = True
        Me.btnFormatoTachado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoTachado.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_strikethrough_16_blanco_255
        Me.btnFormatoTachado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoTachado.Name = "btnFormatoTachado"
        Me.btnFormatoTachado.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoTachado.Tag = "StrikeThrough"
        Me.btnFormatoTachado.Text = "&Tachado"
        '
        'tsSeparadorFormato2
        '
        Me.tsSeparadorFormato2.Name = "tsSeparadorFormato2"
        Me.tsSeparadorFormato2.Size = New System.Drawing.Size(6, 25)
        '
        'btnFormatoAlinearIzquierda
        '
        Me.btnFormatoAlinearIzquierda.CheckOnClick = True
        Me.btnFormatoAlinearIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoAlinearIzquierda.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_align_left_16_blanco_255
        Me.btnFormatoAlinearIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoAlinearIzquierda.Name = "btnFormatoAlinearIzquierda"
        Me.btnFormatoAlinearIzquierda.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoAlinearIzquierda.Tag = "JustifyLeft"
        Me.btnFormatoAlinearIzquierda.Text = "Alineación a la izquierda"
        Me.btnFormatoAlinearIzquierda.ToolTipText = "Alineación a la izquierda"
        '
        'btnFormatoAlineacionCentro
        '
        Me.btnFormatoAlineacionCentro.CheckOnClick = True
        Me.btnFormatoAlineacionCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoAlineacionCentro.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_align_center_16_blanco_255
        Me.btnFormatoAlineacionCentro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoAlineacionCentro.Name = "btnFormatoAlineacionCentro"
        Me.btnFormatoAlineacionCentro.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoAlineacionCentro.Tag = "JustifyCenter"
        Me.btnFormatoAlineacionCentro.Text = "Alineación centrada"
        Me.btnFormatoAlineacionCentro.ToolTipText = "Alineación centrada"
        '
        'btnFormatoAlineacionDerecha
        '
        Me.btnFormatoAlineacionDerecha.CheckOnClick = True
        Me.btnFormatoAlineacionDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoAlineacionDerecha.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_align_right_16_blanco_255
        Me.btnFormatoAlineacionDerecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoAlineacionDerecha.Name = "btnFormatoAlineacionDerecha"
        Me.btnFormatoAlineacionDerecha.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoAlineacionDerecha.Tag = "JustifyRight"
        Me.btnFormatoAlineacionDerecha.Text = "Alineación a la derecha"
        Me.btnFormatoAlineacionDerecha.ToolTipText = "Alineación a la derecha"
        '
        'btnFormatoAlineacionJustificar
        '
        Me.btnFormatoAlineacionJustificar.CheckOnClick = True
        Me.btnFormatoAlineacionJustificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoAlineacionJustificar.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.text_align_justify_16_blanco_255
        Me.btnFormatoAlineacionJustificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoAlineacionJustificar.Name = "btnFormatoAlineacionJustificar"
        Me.btnFormatoAlineacionJustificar.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoAlineacionJustificar.Tag = "JustifyFull"
        Me.btnFormatoAlineacionJustificar.Text = "Justificado"
        Me.btnFormatoAlineacionJustificar.ToolTipText = "Justificado"
        '
        'tsSperadorFormato3
        '
        Me.tsSperadorFormato3.Name = "tsSperadorFormato3"
        Me.tsSperadorFormato3.Size = New System.Drawing.Size(6, 25)
        '
        'btnFormatoListaOrdenada
        '
        Me.btnFormatoListaOrdenada.CheckOnClick = True
        Me.btnFormatoListaOrdenada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormatoListaOrdenada.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.list_16_blanco_255
        Me.btnFormatoListaOrdenada.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormatoListaOrdenada.Name = "btnFormatoListaOrdenada"
        Me.btnFormatoListaOrdenada.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatoListaOrdenada.Tag = "InsertOrderedList"
        Me.btnFormatoListaOrdenada.Text = "Insertar Lista Numerada"
        Me.btnFormatoListaOrdenada.ToolTipText = "Insertar Lista Numerada"
        '
        'tsObjetos
        '
        Me.tsObjetos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsObjetos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsObjetos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminar, Me.btnEnlace, Me.btnImagen, Me.btnLinea, Me.tsSeparadorObjetos1, Me.btnTabulacionIzquierda, Me.btnTabulacionDerecha})
        Me.tsObjetos.Location = New System.Drawing.Point(185, 0)
        Me.tsObjetos.Name = "tsObjetos"
        Me.tsObjetos.Size = New System.Drawing.Size(368, 25)
        Me.tsObjetos.TabIndex = 16
        Me.tsObjetos.Text = "ToolStrip1"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.close_16_blanco_255
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.btnEliminar.Tag = "Delete"
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTipText = "Eliminar"
        '
        'btnEnlace
        '
        Me.btnEnlace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEnlace.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.browser_16_blanco_255
        Me.btnEnlace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnlace.Name = "btnEnlace"
        Me.btnEnlace.Size = New System.Drawing.Size(23, 22)
        Me.btnEnlace.Tag = "CreateLink"
        Me.btnEnlace.Text = "Insertar Hipervínculo"
        Me.btnEnlace.ToolTipText = "Insertar Hipervínculo"
        '
        'btnImagen
        '
        Me.btnImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImagen.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.image_portrait_16_blanco_255
        Me.btnImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(23, 22)
        Me.btnImagen.Tag = "InsertImage"
        Me.btnImagen.Text = "Insertar Imágen"
        '
        'btnLinea
        '
        Me.btnLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLinea.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.dimension_line_width_16_blanco_255
        Me.btnLinea.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLinea.Name = "btnLinea"
        Me.btnLinea.Size = New System.Drawing.Size(23, 22)
        Me.btnLinea.Tag = "InsertHorizontalRule"
        Me.btnLinea.Text = "Insertar Línea"
        Me.btnLinea.ToolTipText = "Insertar Línea"
        '
        'tsSeparadorObjetos1
        '
        Me.tsSeparadorObjetos1.Name = "tsSeparadorObjetos1"
        Me.tsSeparadorObjetos1.Size = New System.Drawing.Size(6, 25)
        '
        'btnTabulacionIzquierda
        '
        Me.btnTabulacionIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTabulacionIzquierda.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.arrow_left_16_blanco_255
        Me.btnTabulacionIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTabulacionIzquierda.Name = "btnTabulacionIzquierda"
        Me.btnTabulacionIzquierda.Size = New System.Drawing.Size(23, 22)
        Me.btnTabulacionIzquierda.Tag = "Outdent"
        Me.btnTabulacionIzquierda.Text = "Disminuir Sangría"
        Me.btnTabulacionIzquierda.ToolTipText = "Disminuir Sangría"
        '
        'btnTabulacionDerecha
        '
        Me.btnTabulacionDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnTabulacionDerecha.Image = Global.Recompila.WYSIWYG.My.Resources.Resources.arrow_right_16_blanco_255
        Me.btnTabulacionDerecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTabulacionDerecha.Name = "btnTabulacionDerecha"
        Me.btnTabulacionDerecha.Size = New System.Drawing.Size(23, 22)
        Me.btnTabulacionDerecha.Tag = "Indent"
        Me.btnTabulacionDerecha.Text = "Aumentar Sangría"
        Me.btnTabulacionDerecha.ToolTipText = "Aumentar Sangría"
        '
        'tmrReloj
        '
        Me.tmrReloj.Interval = 400
        '
        'HTMLEditor
        '
        Me.HTMLEditor.AllowNavigation = False
        Me.HTMLEditor.AllowWebBrowserDrop = False
        Me.tblEditor.SetColumnSpan(Me.HTMLEditor, 2)
        Me.HTMLEditor.IsWebBrowserContextMenuEnabled = False
        Me.HTMLEditor.Location = New System.Drawing.Point(3, 53)
        Me.HTMLEditor.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HTMLEditor.Name = "HTMLEditor"
        Me.HTMLEditor.ScriptErrorsSuppressed = True
        Me.HTMLEditor.Size = New System.Drawing.Size(547, 139)
        Me.HTMLEditor.TabIndex = 19
        '
        'tblEditor
        '
        Me.tblEditor.BackColor = System.Drawing.Color.Transparent
        Me.tblEditor.ColumnCount = 2
        Me.tblEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblEditor.Controls.Add(Me.tsGeneral, 0, 0)
        Me.tblEditor.Controls.Add(Me.HTMLEditor, 0, 2)
        Me.tblEditor.Controls.Add(Me.tsObjetos, 1, 0)
        Me.tblEditor.Controls.Add(Me.tsFormato, 0, 1)
        Me.tblEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblEditor.Location = New System.Drawing.Point(0, 0)
        Me.tblEditor.Name = "tblEditor"
        Me.tblEditor.RowCount = 3
        Me.tblEditor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblEditor.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblEditor.Size = New System.Drawing.Size(553, 195)
        Me.tblEditor.TabIndex = 20
        '
        'krgEditor
        '
        Me.krgEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.krgEditor.Location = New System.Drawing.Point(0, 0)
        Me.krgEditor.Name = "krgEditor"
        '
        'krgEditor.Panel
        '
        Me.krgEditor.Panel.Controls.Add(Me.tblEditor)
        Me.krgEditor.Size = New System.Drawing.Size(555, 197)
        Me.krgEditor.TabIndex = 21
        '
        'cmbFuente
        '
        Me.cmbFuente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFuente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFuente.Name = "cmbFuente"
        Me.cmbFuente.Size = New System.Drawing.Size(150, 25)
        Me.cmbFuente.Tag = "FontName"
        Me.cmbFuente.ToolTipText = "Fuente del texto"
        '
        'rWYSIWYG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.krgEditor)
        Me.Name = "rWYSIWYG"
        Me.Size = New System.Drawing.Size(555, 197)
        Me.tsGeneral.ResumeLayout(False)
        Me.tsGeneral.PerformLayout()
        Me.tsFormato.ResumeLayout(False)
        Me.tsFormato.PerformLayout()
        Me.tsObjetos.ResumeLayout(False)
        Me.tsObjetos.PerformLayout()
        Me.tblEditor.ResumeLayout(False)
        Me.tblEditor.PerformLayout()
        CType(Me.krgEditor.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.krgEditor.Panel.ResumeLayout(False)
        CType(Me.krgEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.krgEditor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tsGeneral As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCortar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPegar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSeparadorGeneral2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDeshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRedo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsFormato As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbTamanho As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsSeparadorFormato1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFormatoNegrita As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFormatoCursiva As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFormatoSubrayado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSeparadorFormato2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFormatoAlinearIzquierda As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFormatoAlineacionCentro As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFormatoAlineacionDerecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFormatoTachado As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFormatoAlineacionJustificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSeparadorGeneral1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsObjetos As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnlace As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSeparadorObjetos1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLinea As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTabulacionIzquierda As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTabulacionDerecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrReloj As System.Windows.Forms.Timer
    Friend WithEvents tsSperadorFormato3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFormatoListaOrdenada As System.Windows.Forms.ToolStripButton
    Public WithEvents HTMLEditor As System.Windows.Forms.WebBrowser
    Friend WithEvents btnColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImagen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ttpInformación As System.Windows.Forms.ToolTip
    Friend WithEvents tblEditor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents krgEditor As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents cmbFuente As System.Windows.Forms.ToolStripComboBox

End Class
