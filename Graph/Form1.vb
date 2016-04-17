Imports Microsoft.VisualBasic.CompilerServices

Public Class Form1

    Private _bkTrian1 As Double
    Private _bkTrian2 As Double
    Private _akTrian1 As Double
    Private _akTrian2 As Double

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Chart1.ChartAreas(0).AxisY.Maximum = 2
        Chart1.ChartAreas(0).AxisY.Minimum = -1
        'CalculateAkFunc()
        Chart2.ChartAreas(0).AxisY.Maximum = 0.5
        Chart2.ChartAreas(0).AxisY.Minimum = 0
        Chart2.ChartAreas(0).AxisX.Maximum = 10
        Chart2.ChartAreas(0).AxisX.Minimum = 0
    End Sub



    Dim q As Double = 2
    Dim ti As Double = 50
    Dim TB As Double = q * ti
    Dim M As Double = 3

    Dim w0 = 2 * Math.PI / TB

    


    Sub CalculateAkFunc()
        For k As Double = 1 To 10
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkRect(k), 2) + Math.Pow(BkRect(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkTrain1(k), 2) + Math.Pow(BkTrain1(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkTrain2(k), 2) + Math.Pow(BkTrain2(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkFloorCos1(k), 2) + Math.Pow(BkFloorCos1(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkFloorCos2(k), 2) + Math.Pow(BkFloorCos2(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkObr(k), 2) + Math.Pow(BkObr(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkCos1(k), 2) + Math.Pow(BkCos1(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkCos2(k), 2) + Math.Pow(BkCos2(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkEx1(k), 2) + Math.Pow(BkEx1(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkEx2(k), 2) + Math.Pow(BkEx2(k), 2)))
            Debug.WriteLine(Math.Sqrt(Math.Pow(AkExp(k), 2) + Math.Pow(BkExp(k), 2)))
        Next
    End Sub

    Sub DrawLine()

        If (Not Chart1.Series.Any()) Then
            Return
        End If


        Chart1.Series(0).Points.Clear()

        For t As Double = 1 To 349 Step 1
            Dim y As Double = 0

            If (RadioRect.Checked) Then
                y = SmRect(t)
            ElseIf (RadioTrian1.Checked) Then
                y = SmTrian1(t)
            ElseIf (RadioTrian2.Checked) Then
                y = SmTrian2(t)
            ElseIf (RadioFloorCos1.Checked) Then
                y = SmFloorCos1(t)
            ElseIf (RadioFloorCos2.Checked) Then
                y = SmFloorCos2(t)
            ElseIf (RadioObr.Checked) Then
                y = SmObr(t)
            ElseIf (RadioCos1.Checked) Then
                y = SmCos1(t)
            ElseIf (RadioCos2.Checked) Then
                y = SmCos2(t)
            ElseIf (RadioEx1.Checked) Then
                y = SmEx1(t)
            ElseIf (RadioEx2.Checked) Then
                y = SmEx2(t)
            ElseIf (RadioExp.Checked) Then
                y = SmExp(t)
            End If

            Chart1.Series(0).Points.AddXY(t, y)


        Next
    End Sub
    Sub DrawLine2()
        If (Not Chart2.Series.Any()) Then
            Return
        End If

        Chart2.Series(0).Points.Clear()


        For k As Double = 1 To 10
            Dim y As Double = 0
            If (RadioRect.Checked) Then
                y = Math.Sqrt(Math.Pow(AkRect(k), 2) + Math.Pow(BkRect(k), 2))
            ElseIf (RadioTrian1.Checked) Then
                y = Math.Sqrt(Math.Pow(AkTrain1(k), 2) + Math.Pow(BkTrain1(k), 2))
            ElseIf (RadioTrian2.Checked) Then
                y = Math.Sqrt(Math.Pow(AkTrain2(k), 2) + Math.Pow(BkTrain2(k), 2))
            ElseIf (RadioFloorCos1.Checked) Then
                y = Math.Sqrt(Math.Pow(AkFloorCos1(k), 2) + Math.Pow(BkFloorCos1(k), 2))
            ElseIf (RadioFloorCos2.Checked) Then
                y = Math.Sqrt(Math.Pow(AkFloorCos2(k), 2) + Math.Pow(BkFloorCos2(k), 2))
            ElseIf (RadioObr.Checked) Then
                y = Math.Sqrt(Math.Pow(AkObr(k), 2) + Math.Pow(BkObr(k), 2))
            ElseIf (RadioCos1.Checked) Then
                y = Math.Sqrt(Math.Pow(AkCos1(k), 2) + Math.Pow(BkCos1(k), 2))
            ElseIf (RadioCos2.Checked) Then
                y = Math.Sqrt(Math.Pow(AkCos2(k), 2) + Math.Pow(BkCos2(k), 2))
            ElseIf (RadioEx1.Checked) Then
                y = Math.Sqrt(Math.Pow(AkEx1(k), 2) + Math.Pow(BkEx1(k), 2))
            ElseIf (RadioEx2.Checked) Then
                y = Math.Sqrt(Math.Pow(AkEx2(k), 2) + Math.Pow(BkEx2(k), 2))
            ElseIf (RadioExp.Checked) Then
                y = Math.Sqrt(Math.Pow(AkExp(k), 2) + Math.Pow(BkExp(k), 2))
            End If

            Chart2.Series(0).Points.AddXY(k, y)

        Next
    End Sub

    'прямоугольный сигнал 
    Function SmRect(ByVal t As Double) As Double
        Dim sum As Double
        For k As Double = 1 To M
            sum += AkRect(k) * Math.Cos(k * w0 * t)
        Next

        Dim a0 = (2 * ti) / TB
        Return a0 / 2 + sum
    End Function

    Function AkRect(ByVal k As Double) As Double
        Return 2 * (Math.Sin(Math.PI * k * ti / TB)) / (k * Math.PI)
    End Function

    Function BkRect(ByVal k As Double) As Double
        Return 0
    End Function


    'Симметрично-треугольный
    Function SmExp(ByVal t As Double) As Double

        Dim sum As Double
        For k As Double = 1 To M
            sum += AkExp(k) * Math.Cos(k * w0 * t)
        Next

        Dim a0 = ti / TB
        Return a0 / 2 + sum
    End Function

    Function AkExp(ByVal k As Double) As Double

        Dim a = Math.Pow(Math.Sin(Math.PI * ti * k / (2 * TB)), 2)
        Dim b = Math.Pow(Math.PI, 2) * ti * Math.Pow(k, 2)

        Return 4 * TB * a / b
    End Function

    Function BkExp(ByVal k As Integer) As Double
        Return 0
    End Function


    'Несимметрично-треугольный №1
    Function SmTrian1(ByVal t As Double) As Double
        Dim a0 = ti / TB

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkTrain1(k) * Math.Cos(k * w0 * t) + BkTrain1(k) * Math.Sin(k * w0 * t))
        Next

        Return a0 / 2 + sum
    End Function

    Function AkTrain1(ByVal k As Double) As Double

        Dim a = Math.Pow(Math.Cos(Math.PI * ti * k / TB), 2) - 1
        Dim b = Math.PI * ti * k * Math.Sin(2 * Math.PI * ti * k / TB)


        Return (TB * a + b) /
        (Math.Pow(Math.PI, 2) * ti * Math.Pow(k, 2))
    End Function

    Function BkTrain1(ByVal k As Double) As Double
        Dim a As Double = TB * Math.Sin(2 * Math.PI * ti * k / TB) - 2 * Math.PI * ti * k * Math.Cos(2 * Math.PI * ti * k / TB)
        Dim b As Double = 2 * Math.Pow(Math.PI, 2) * ti * Math.Pow(k, 2)

        Return a / b
    End Function


    'Несимметрично-треугольный №2
    Function SmTrian2(ByVal t As Double) As Double
        Dim a0 = ((-ti / TB) + 1)

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkTrain2(k) * Math.Cos(k * w0 * t) + BkTrain2(k) * Math.Sin(k * w0 * t))
        Next

        Return a0 / 2 + sum
    End Function

    Function AkTrain2(ByVal k As Double) As Double

        Dim a = Math.Pow(Math.Sin((Math.PI * k) / 2), 2)
        Dim b = Math.Pow(Math.PI * k, 2)


        Return (2 * a) / b

    End Function

    Function BkTrain2(ByVal k As Double) As Double
        Dim a As Double = Math.Sin(Math.PI * k) - Math.PI * k
        Dim b As Double = Math.Pow(Math.PI * k, 2)

        Return -a / b
    End Function


    'Полукосинусоидный №1
    Function SmFloorCos1(ByVal t As Double) As Double
        Dim a0 As Double = (4 * ti) / (Math.PI * TB)

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkFloorCos1(k) * Math.Cos(k * w0 * t) + BkFloorCos1(k) * Math.Sin(k * w0 * t))
        Next
        Return a0 / 2 + sum
    End Function

    Function AkFloorCos1(ByVal k As Double) As Double
        Dim a = 4 * TB * ti - 16 * Math.Pow(ti, 2) * k * Math.Sin(2 * Math.PI * ti * k / TB)
        Dim b = Math.PI * Math.Pow(TB, 2) - 16 * Math.PI * Math.Pow(ti, 2) * Math.Pow(k, 2)

        Return a / b

    End Function

    Function BkFloorCos1(ByVal k As Double) As Double
        Dim a = 16 * Math.Pow(ti, 2) * k * (2 * Math.Pow(Math.Sin(Math.PI * ti * k / TB), 2) - 1)
        Dim b = Math.PI * Math.Pow(TB, 2) - 16 * Math.PI * Math.Pow(ti, 2) * Math.Pow(k, 2)

        Return a / b
    End Function


    'Полукосинусоидный №2
    Function SmFloorCos2(ByVal t As Double) As Double
        Dim a0 As Double = (4 * ti) / (Math.PI * TB)

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkFloorCos2(k) * Math.Cos(k * w0 * t) + BkFloorCos2(k) * Math.Sin(k * w0 * t))
        Next
        Return a0 / 2 + sum
    End Function

    Function AkFloorCos2(ByVal k As Double) As Double
        Dim a = 4 * k * Math.Sin(Math.PI * k) - 2
        Dim b = 4 * Math.PI * Math.Pow(k, 2) - Math.PI

        Return a / b

    End Function

    Function BkFloorCos2(ByVal k As Double) As Double
        Dim a = 4 * k * (2 * Math.Pow(Math.Sin(Math.PI * k / 2), 2) - 1)
        Dim b = 4 * Math.PI * Math.Pow(k, 2) - Math.PI

        Return a / b
    End Function


    'Обратно-косинусоидный
    Function SmObr(ByVal t As Double) As Double
        Dim a0 As Double = (4 * ti) / (Math.PI * TB)

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkObr(k) * Math.Cos(k * w0 * t) + BkObr(k) * Math.Sin(k * w0 * t))
        Next
        Return a0 / 2 + sum
    End Function

    Function AkObr(ByVal k As Double) As Double
        Dim a = 2 * Math.Sin(Math.PI * k / 2) + 4 * k * Math.Pow(Math.Sin(Math.PI * k / 4), 2) - 2 * k - 2 * Math.Pow(k, 2) * Math.Sin(Math.PI * k / 2)
        Dim b = Math.PI * k - Math.PI * Math.Pow(k, 3)

        If (b = 0) Then
            Return 0.137
        End If
        Return a / b
    End Function

    Function BkObr(ByVal k As Double) As Double
        Return 0
    End Function


    'Полнокосинусоидный
    Function SmCos1(ByVal t As Double) As Double
        Dim a0 As Double = ti / TB

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkCos1(k) * Math.Cos(k * w0 * t) + BkCos1(k) * Math.Sin(k * w0 * t))
        Next
        Return a0 / 2 + sum
    End Function

    Function AkCos1(ByVal k As Double) As Double

        Dim a = 4 * Math.Sin((Math.PI * k) / 2)
        Dim b = Math.PI * k * (Math.Pow(k, 2) - 4)

        If (b = 0) Then
            Return 0.25

        End If

        Return -a / b
    End Function

    Function BkCos1(ByVal k As Double) As Double
        Return 0
    End Function


    'Обратно-полнокосинусоидный
    Function SmCos2(ByVal t As Double) As Double
        Dim a0 As Double = ti / TB

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkCos2(k) * Math.Cos(k * w0 * t) + BkCos2(k) * Math.Sin(k * w0 * t))
        Next
        Return a0 / 2 + sum
    End Function

    Function AkCos2(ByVal k As Double) As Double

        Dim a = 2 * Math.Sin((Math.PI * k) / 2) * (Math.Pow(k, 2) - 2)
        Dim b = Math.PI * k * (Math.Pow(k, 2) - 4)

        If (b = 0) Then
            Return 0.25

        End If

        Return a / b
    End Function

    Function BkCos2(ByVal k As Double) As Double
        Return 0
    End Function


    'Экспоненциальный №1
    Function SmEx1(ByVal t As Double) As Double
        Dim a0 As Double = ti / TB

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkEx1(k) * Math.Cos(k * w0 * t) + BkEx1(k) * Math.Sin(k * w0 * t))
        Next
        Return a0 / 2 + sum
    End Function

    Function AkEx1(ByVal k As Double) As Double

        Dim a = Math.Sin(Math.PI * k) - 2 * k

        Dim b = 4 * Math.PI * Math.Pow(k, 3) - Math.PI * k

        Return -a / b
    End Function

    Function BkEx1(ByVal k As Double) As Double
        Dim a = 4 * Math.Pow(k, 2) - 2 * Math.Pow(Math.Sin((Math.PI * k) / 2), 2)
        Dim b = 4 * Math.PI * Math.Pow(k, 3) - Math.PI * k


        Return a / b
    End Function


    'Экспоненциальный №2
    Function SmEx2(ByVal t As Double) As Double
        Dim a0 As Double = ti / TB

        Dim sum As Double
        For k As Double = 1 To M
            sum += (AkEx2(k) * Math.Cos(k * w0 * t) + BkEx2(k) * Math.Sin(k * w0 * t))
        Next
        Return a0 / 2 + sum
    End Function

    Function AkEx2(ByVal k As Double) As Double

        Dim a = Math.Sin(Math.PI * k) + 4 * k * Math.Pow(Math.Sin((Math.PI * k) / 2), 2) - 2 * k - 4 * Math.Pow(k, 2) * Math.Sin(Math.PI * k)

        Dim b = Math.PI * k - 4 * Math.PI * Math.Pow(k, 3)



        Return a / b
    End Function

    Function BkEx2(ByVal k As Double) As Double
        Dim a = 2 * k * Math.Sin(Math.PI * k) - 2 * Math.Pow(Math.Sin((Math.PI * k) / 2), 2) + 8 * Math.Pow(k, 2) * Math.Pow(Math.Sin((Math.PI * k) / 2), 2) - 4 * Math.Pow(k, 2)

        Dim b = Math.PI * k - 4 * Math.PI * Math.Pow(k, 3)


        Return -a / b
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        M = NumericUpDown1.Value
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioRect_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRect.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioTrian1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTrian1.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioTrian2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTrian2.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioCos1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCos1.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioCos2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCos2.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioEx1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioEx1.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioEx2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioEx2.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioExp_CheckedChanged(sender As Object, e As EventArgs) Handles RadioExp.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioObr_CheckedChanged(sender As Object, e As EventArgs) Handles RadioObr.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioFloorCos1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFloorCos1.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub RadioFloorCos2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFloorCos2.CheckedChanged
        DrawLine()
        DrawLine2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        M = NumericUpDown1.Value
        DrawLine()
        DrawLine2()
    End Sub


End Class


