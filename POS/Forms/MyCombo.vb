Public Class MyCombo
    Private mID As Int32
    Private mDescription As String

    Public Sub New(ByVal MyID As Int32, ByVal MyDesc As String)
        mID = MyID
        mDescription = MyDesc
    End Sub

    Public Property ID() 'Property that holds record id
        Get
            Return mID
        End Get
        Set(ByVal value)
            mID = value
        End Set
    End Property
    Public Property Description() 'Property for text display
        Get
            Return mDescription
        End Get
        Set(ByVal value)
            mDescription = value
        End Set
    End Property
End Class
