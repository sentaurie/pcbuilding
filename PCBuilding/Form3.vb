Public Class Form3
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(5)
        UserControl12.priceLabel.Text = 320.ToString("C2")
        UserControl12.productNameLabel.Text = "Intel Core i5-14600K"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(2)
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class