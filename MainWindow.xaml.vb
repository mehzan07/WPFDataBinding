Imports System.Windows

Namespace WPFDataBinding
    Partial Public Class MainWindow
        Inherits Window

        Private person As Person = New Person With {
            .Name = "Salman",
            .Age = 26
        }

        Public Sub New()
            InitializeComponent()
            Me.DataContext = person
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim message As String = person.Name & " is " & person.Age
            MessageBox.Show(message)
        End Sub
    End Class

    Public Class Person
        Private nameValue As String

        Public Property Name As String
            Get
                Return nameValue
            End Get
            Set(ByVal value As String)
                nameValue = value
            End Set
        End Property

        Private ageValue As Double

        Public Property Age As Double
            Get
                Return ageValue
            End Get
            Set(ByVal value As Double)

                If value <> ageValue Then
                    ageValue = value
                End If
            End Set
        End Property
    End Class
End Namespace
