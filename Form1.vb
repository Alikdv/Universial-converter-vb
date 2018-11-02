'Project: The Universal Converter
'programm to do unit conversions.
'Copyright(C) 2018 Alexei Dvorezki
'email: alikdv@gmail.com
'This program Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'any later version.

'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'See <https://www.gnu.org/licenses/> to receive a copy of the GNU General Public Licen

Public Class Form1

    Dim Celsius As String = "*************************** Formula: °C x 1.8 + 32 = °F *****"
    Dim Centimeter As String = "************************ Formula: cm * 2.54 = Inches *****"
    Dim Hours As String = "*************************** Formula: Hours * 60 = Minutes *****"
    Dim Kilometer As String = "*********************** Formula: km * 1000 = Meter *****"

    Dim Number As Integer
    Dim Answer As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Celsius")
        ComboBox1.Items.Add("Centimeter")
        ComboBox1.Items.Add("Hours")
        ComboBox1.Items.Add("Kilometer")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "Celsius" Then
            Number = datataConvertIn.Text
            Answer = Number * 1.8 + 32
            resultOut.Text = FormatNumber(Answer)

        End If
        If ComboBox1.SelectedItem = "Centimeter" Then
            Number = datataConvertIn.Text
            Answer = Number * 2.54
            resultOut.Text = FormatNumber(Answer)
        End If
        If ComboBox1.SelectedItem = "Hours" Then
            Number = datataConvertIn.Text
            Answer = Number * 60
            resultOut.Text = FormatNumber(Answer)
        End If
        If ComboBox1.SelectedItem = "Kilometer" Then
            Number = datataConvertIn.Text
            Answer = Number * 1000
            resultOut.Text = FormatNumber(Answer)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Celsius" Then
            RichTextBox1.Text = ("Fahrenheir")
            GroupBox1.Text = ComboBox1.SelectedItem & "(" & Celsius & ")"

        End If
        If ComboBox1.SelectedItem = "Centimeter" Then
            RichTextBox1.Text = ("Inches")
            GroupBox1.Text = ComboBox1.SelectedItem & "(" & Centimeter & ")"
        End If
        If ComboBox1.SelectedItem = "Hours" Then
            RichTextBox1.Text = ("Minutes")
            GroupBox1.Text = ComboBox1.SelectedItem & "(" & Hours & ")"
        End If
        If ComboBox1.SelectedItem = "Kilometer" Then
            RichTextBox1.Text = ("Metre")
            GroupBox1.Text = ComboBox1.SelectedItem & "(" & Kilometer & ")"
        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub datataConvertIn_TextChanged(sender As Object, e As EventArgs) Handles datataConvertIn.TextChanged

    End Sub
End Class
