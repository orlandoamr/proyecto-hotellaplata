<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.cmbRoles = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(533, 819)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 20)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Haga doble click sobre un registro para editarlo"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.ColumnHeadersHeight = 35
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.Location = New System.Drawing.Point(371, 114)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUsuarios.RowTemplate.Height = 24
        Me.dgvUsuarios.Size = New System.Drawing.Size(686, 702)
        Me.dgvUsuarios.TabIndex = 124
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(443, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 23)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Control usuarios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 20)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Código del empleado"
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.AccessibleName = "código del empleado"
        Me.txtCodigoEmpleado.Enabled = False
        Me.txtCodigoEmpleado.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoEmpleado.Location = New System.Drawing.Point(29, 122)
        Me.txtCodigoEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoEmpleado.MaxLength = 29
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.Size = New System.Drawing.Size(254, 25)
        Me.txtCodigoEmpleado.TabIndex = 112
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Delete_icon
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.Location = New System.Drawing.Point(19, 18)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btnCerrar.Size = New System.Drawing.Size(45, 42)
        Me.btnCerrar.TabIndex = 126
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarCampos.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarCampos.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnLimpiarCampos.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Clear_Symbol_icon_2
        Me.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(32, 497)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(298, 48)
        Me.btnLimpiarCampos.TabIndex = 123
        Me.btnLimpiarCampos.Text = "Limpiar"
        Me.btnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnGuardar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Save_icon
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(32, 443)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(298, 48)
        Me.btnGuardar.TabIndex = 122
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBuscarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(287, 114)
        Me.btnBuscarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(42, 41)
        Me.btnBuscarEmpleado.TabIndex = 118
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 179)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Nombre de usuario"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.AccessibleName = "nombre de usuario"
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(31, 199)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreUsuario.MaxLength = 20
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(298, 25)
        Me.txtNombreUsuario.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 258)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Contraseña"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.AccessibleName = "contraseña"
        Me.txtContrasenia.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(32, 278)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContrasenia.MaxLength = 20
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(298, 25)
        Me.txtContrasenia.TabIndex = 129
        Me.txtContrasenia.UseSystemPasswordChar = True
        '
        'cmbRoles
        '
        Me.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoles.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoles.FormattingEnabled = True
        Me.cmbRoles.Items.AddRange(New Object() {"Administrador", "Usuario"})
        Me.cmbRoles.Location = New System.Drawing.Point(33, 356)
        Me.cmbRoles.Name = "cmbRoles"
        Me.cmbRoles.Size = New System.Drawing.Size(296, 28)
        Me.cmbRoles.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 333)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Rol"
        '
        'frmControlUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1077, 852)
        Me.Controls.Add(Me.cmbRoles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodigoEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmControlUsuarios"
        Me.Text = "frmControlUsuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Private WithEvents Label1 As Label
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnBuscarEmpleado As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigoEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents cmbRoles As ComboBox
    Friend WithEvents Label4 As Label
End Class
