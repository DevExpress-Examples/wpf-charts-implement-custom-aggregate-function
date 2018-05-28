Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DataAggregationSample.Model
    Friend Class CurrencyRate
        Private privateDate As Date
        Public Property [Date]() As Date
            Get
                Return privateDate
            End Get
            Private Set(ByVal value As Date)
                privateDate = value
            End Set
        End Property
        Private privateValue As Double
        Public Property Value() As Double
            Get
                Return privateValue
            End Get
            Private Set(ByVal value As Double)
                privateValue = value
            End Set
        End Property

        Public Sub New(ByVal [date] As Date, ByVal value As Double)
            Me.Date = [date]
            Me.Value = value
        End Sub
    End Class
End Namespace
