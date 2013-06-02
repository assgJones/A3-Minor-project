Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "Evidence of research and preparation"
        Label4.Text = "Relevance of material to the topic"
        Label5.Text = "Arguments - coherent & logical"
        Label6.Text = "Rebuttal"

        Label7.Text = "Effective introduction"
        Label8.Text = "Use of definitions & theme"
        Label9.Text = "Organisation of the speech"
        Label10.Text = "Suport for other team members"
        Label11.Text = "Effective conclusion"

        Label12.Text = "Voice - variation and intersest"
        Label13.Text = "Eye contact"
        Label14.Text = "Stance and gesture'"
        Label15.Text = "Rapport with audience"
        Dim sliders() As HScrollBar = {HScrollBar1, HScrollBar10, HScrollBar11, HScrollBar12, HScrollBar13, HScrollBar14, HScrollBar15, HScrollBar2, HScrollBar3, HScrollBar4, HScrollBar5, HScrollBar6, HScrollBar7, HScrollBar8, HScrollBar9}
        For Each slider In sliders
            slider.Maximum = 8
            slider.Minimum = 0
            slider.LargeChange = 4
            slider.SmallChange = 1
            slider.Value = 0
            slider.
        Next()

    End Sub

    Private Sub BackBtnPressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class