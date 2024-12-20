Public Class frm_livre


    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click
        Dim l As livre
        l.ISBN = Txt_isbn.Text
        l.titre = Txt_titre.Text
        l.auteur = Txt_auteur.Text
        If AjouterLivre(l) Then
            MessageBox.Show("Ajout de livre avec succes")
        Else
            MessageBox.Show("le tableau bibliothéque est saturé")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class
