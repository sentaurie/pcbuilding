Public Class Form3
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(5)
        UserControl12.priceLabel.Text = 320.ToString("C2")
        UserControl12.productNameLabel.Text = "Intel Core i5-14600K"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserControl12.PictureBox1.Image = UserControl12.ImageList1.Images(6)
        UserControl12.priceLabel.Text = 400.ToString("C2")
        UserControl12.productNameLabel.Text = "Intel Core i7-14700K"
        UserControl11.descriptionTextBox.Text = "20 cores, 28 threads, Intel UHD Graphics 770, Hybrid architecture, optimized performance, 5.6 GHz, 33MB Cache, Intel 600/700-series compatible, Turbo Boost Max Technology 3.0, PCIe support, DDR4 and DDR5 Memory support"
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class