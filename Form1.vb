Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        ListBox1.Items.Add(TextBox1.Text)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        MessageBox.Show(ListBox1.SelectedItem.ToString())



    End Sub


End Class
