<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 1
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(303, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 2
        Label2.Text = "titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(502, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 4
        Label3.Text = "auteur"
        ' 
        ' lst_isbn
        ' 
        lst_isbn.FormattingEnabled = True
        lst_isbn.ItemHeight = 15
        lst_isbn.Location = New Point(120, 103)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(120, 184)
        lst_isbn.TabIndex = 5
        ' 
        ' lst_titre
        ' 
        lst_titre.FormattingEnabled = True
        lst_titre.ItemHeight = 15
        lst_titre.Location = New Point(303, 103)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(120, 184)
        lst_titre.TabIndex = 6
        ' 
        ' lst_auteur
        ' 
        lst_auteur.FormattingEnabled = True
        lst_auteur.ItemHeight = 15
        lst_auteur.Location = New Point(502, 103)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(120, 184)
        lst_auteur.TabIndex = 7
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Ist_titre"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
End Class
