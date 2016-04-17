<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim LineAnnotation1 As System.Windows.Forms.DataVisualization.Charting.LineAnnotation = New System.Windows.Forms.DataVisualization.Charting.LineAnnotation()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioEx2 = New System.Windows.Forms.RadioButton()
        Me.RadioEx1 = New System.Windows.Forms.RadioButton()
        Me.RadioObr = New System.Windows.Forms.RadioButton()
        Me.RadioFloorCos2 = New System.Windows.Forms.RadioButton()
        Me.RadioCos2 = New System.Windows.Forms.RadioButton()
        Me.RadioTrian2 = New System.Windows.Forms.RadioButton()
        Me.RadioExp = New System.Windows.Forms.RadioButton()
        Me.RadioCos1 = New System.Windows.Forms.RadioButton()
        Me.RadioFloorCos1 = New System.Windows.Forms.RadioButton()
        Me.RadioTrian1 = New System.Windows.Forms.RadioButton()
        Me.RadioRect = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(12, 327)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(482, 309)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(190, 299)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioEx2)
        Me.GroupBox1.Controls.Add(Me.RadioEx1)
        Me.GroupBox1.Controls.Add(Me.RadioObr)
        Me.GroupBox1.Controls.Add(Me.RadioFloorCos2)
        Me.GroupBox1.Controls.Add(Me.RadioCos2)
        Me.GroupBox1.Controls.Add(Me.RadioTrian2)
        Me.GroupBox1.Controls.Add(Me.RadioExp)
        Me.GroupBox1.Controls.Add(Me.RadioCos1)
        Me.GroupBox1.Controls.Add(Me.RadioFloorCos1)
        Me.GroupBox1.Controls.Add(Me.RadioTrian1)
        Me.GroupBox1.Controls.Add(Me.RadioRect)
        Me.GroupBox1.Location = New System.Drawing.Point(500, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 284)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Выбор сигнала"
        '
        'RadioEx2
        '
        Me.RadioEx2.AutoSize = True
        Me.RadioEx2.Location = New System.Drawing.Point(6, 254)
        Me.RadioEx2.Name = "RadioEx2"
        Me.RadioEx2.Size = New System.Drawing.Size(144, 17)
        Me.RadioEx2.TabIndex = 10
        Me.RadioEx2.TabStop = True
        Me.RadioEx2.Text = "Экспоненциальный №2"
        Me.RadioEx2.UseVisualStyleBackColor = True
        '
        'RadioEx1
        '
        Me.RadioEx1.AutoSize = True
        Me.RadioEx1.Location = New System.Drawing.Point(6, 231)
        Me.RadioEx1.Name = "RadioEx1"
        Me.RadioEx1.Size = New System.Drawing.Size(144, 17)
        Me.RadioEx1.TabIndex = 9
        Me.RadioEx1.TabStop = True
        Me.RadioEx1.Text = "Экспоненциальный №1"
        Me.RadioEx1.UseVisualStyleBackColor = True
        '
        'RadioObr
        '
        Me.RadioObr.AutoSize = True
        Me.RadioObr.Location = New System.Drawing.Point(6, 162)
        Me.RadioObr.Name = "RadioObr"
        Me.RadioObr.Size = New System.Drawing.Size(150, 17)
        Me.RadioObr.TabIndex = 8
        Me.RadioObr.TabStop = True
        Me.RadioObr.Text = "Обратно-косинусоидный"
        Me.RadioObr.UseVisualStyleBackColor = True
        '
        'RadioFloorCos2
        '
        Me.RadioFloorCos2.AutoSize = True
        Me.RadioFloorCos2.Location = New System.Drawing.Point(6, 139)
        Me.RadioFloorCos2.Name = "RadioFloorCos2"
        Me.RadioFloorCos2.Size = New System.Drawing.Size(149, 17)
        Me.RadioFloorCos2.TabIndex = 7
        Me.RadioFloorCos2.TabStop = True
        Me.RadioFloorCos2.Text = "Полукосинусоидный №2"
        Me.RadioFloorCos2.UseVisualStyleBackColor = True
        '
        'RadioCos2
        '
        Me.RadioCos2.AutoSize = True
        Me.RadioCos2.Location = New System.Drawing.Point(6, 208)
        Me.RadioCos2.Name = "RadioCos2"
        Me.RadioCos2.Size = New System.Drawing.Size(180, 17)
        Me.RadioCos2.TabIndex = 6
        Me.RadioCos2.TabStop = True
        Me.RadioCos2.Text = "Обратно-полнокосинусоидный"
        Me.RadioCos2.UseVisualStyleBackColor = True
        '
        'RadioTrian2
        '
        Me.RadioTrian2.AutoSize = True
        Me.RadioTrian2.Location = New System.Drawing.Point(6, 93)
        Me.RadioTrian2.Name = "RadioTrian2"
        Me.RadioTrian2.Size = New System.Drawing.Size(195, 17)
        Me.RadioTrian2.TabIndex = 5
        Me.RadioTrian2.TabStop = True
        Me.RadioTrian2.Text = "Несимметрично-треугольный №2"
        Me.RadioTrian2.UseVisualStyleBackColor = True
        '
        'RadioExp
        '
        Me.RadioExp.AutoSize = True
        Me.RadioExp.Location = New System.Drawing.Point(6, 47)
        Me.RadioExp.Name = "RadioExp"
        Me.RadioExp.Size = New System.Drawing.Size(162, 17)
        Me.RadioExp.TabIndex = 4
        Me.RadioExp.Text = "Симметрично-треугольный"
        Me.RadioExp.UseVisualStyleBackColor = True
        '
        'RadioCos1
        '
        Me.RadioCos1.AutoSize = True
        Me.RadioCos1.Location = New System.Drawing.Point(6, 185)
        Me.RadioCos1.Name = "RadioCos1"
        Me.RadioCos1.Size = New System.Drawing.Size(136, 17)
        Me.RadioCos1.TabIndex = 3
        Me.RadioCos1.Text = "Полнокосинусоидный"
        Me.RadioCos1.UseVisualStyleBackColor = True
        '
        'RadioFloorCos1
        '
        Me.RadioFloorCos1.AutoSize = True
        Me.RadioFloorCos1.Location = New System.Drawing.Point(6, 116)
        Me.RadioFloorCos1.Name = "RadioFloorCos1"
        Me.RadioFloorCos1.Size = New System.Drawing.Size(149, 17)
        Me.RadioFloorCos1.TabIndex = 2
        Me.RadioFloorCos1.Text = "Полукосинусоидный №1"
        Me.RadioFloorCos1.UseVisualStyleBackColor = True
        '
        'RadioTrian1
        '
        Me.RadioTrian1.AutoSize = True
        Me.RadioTrian1.Location = New System.Drawing.Point(6, 70)
        Me.RadioTrian1.Name = "RadioTrian1"
        Me.RadioTrian1.Size = New System.Drawing.Size(195, 17)
        Me.RadioTrian1.TabIndex = 1
        Me.RadioTrian1.Text = "Несимметрично-треугольный №1"
        Me.RadioTrian1.UseVisualStyleBackColor = True
        '
        'RadioRect
        '
        Me.RadioRect.AutoSize = True
        Me.RadioRect.Checked = True
        Me.RadioRect.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadioRect.Location = New System.Drawing.Point(6, 24)
        Me.RadioRect.Name = "RadioRect"
        Me.RadioRect.Size = New System.Drawing.Size(107, 17)
        Me.RadioRect.TabIndex = 0
        Me.RadioRect.TabStop = True
        Me.RadioRect.Text = "Прямоугольный"
        Me.RadioRect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(187, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Количество гармоник"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Старт"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(350, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Выход"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Chart2
        '
        LineAnnotation1.Name = "LineAnnotation1"
        Me.Chart2.Annotations.Add(LineAnnotation1)
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Location = New System.Drawing.Point(12, 25)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series2.ChartArea = "ChartArea1"
        Series2.IsXValueIndexed = True
        Series2.Name = "Series1"
        Series2.YValuesPerPoint = 2
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(482, 255)
        Me.Chart2.TabIndex = 6
        Me.Chart2.Text = "Chart2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "График спектра сигнала"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 648)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form1"
        Me.Text = "СИНТЕЗ СИГНАЛА ПО РЯДУ ФУРЬЕ"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioExp As System.Windows.Forms.RadioButton
    Friend WithEvents RadioCos1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioFloorCos1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioTrian1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioRect As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioFloorCos2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioCos2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioTrian2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioObr As System.Windows.Forms.RadioButton
    Friend WithEvents RadioEx2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioEx1 As System.Windows.Forms.RadioButton
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
