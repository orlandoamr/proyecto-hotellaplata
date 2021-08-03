<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrada
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.crtHabitaciones = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.crtVentasAnio = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.crtHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crtVentasAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(305, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(436, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Top 5 habitaciones más vendidas de este mes"
        '
        'crtHabitaciones
        '
        Me.crtHabitaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.crtHabitaciones.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.crtHabitaciones.Legends.Add(Legend1)
        Me.crtHabitaciones.Location = New System.Drawing.Point(225, 35)
        Me.crtHabitaciones.Name = "crtHabitaciones"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.crtHabitaciones.Series.Add(Series1)
        Me.crtHabitaciones.Size = New System.Drawing.Size(629, 361)
        Me.crtHabitaciones.TabIndex = 9
        Me.crtHabitaciones.Text = "Chart1"
        '
        'crtVentasAnio
        '
        Me.crtVentasAnio.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        ChartArea2.Name = "ChartArea1"
        Me.crtVentasAnio.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.crtVentasAnio.Legends.Add(Legend2)
        Me.crtVentasAnio.Location = New System.Drawing.Point(225, 460)
        Me.crtVentasAnio.Name = "crtVentasAnio"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.crtVentasAnio.Series.Add(Series2)
        Me.crtVentasAnio.Size = New System.Drawing.Size(629, 361)
        Me.crtVentasAnio.TabIndex = 11
        Me.crtVentasAnio.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(369, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ventas por mes de este año"
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1077, 852)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crtVentasAnio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.crtHabitaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEntrada"
        Me.Text = "frmEntrada"
        CType(Me.crtHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crtVentasAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents crtHabitaciones As DataVisualization.Charting.Chart
    Friend WithEvents crtVentasAnio As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
End Class
