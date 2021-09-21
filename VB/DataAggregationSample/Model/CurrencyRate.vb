Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DataAggregationSample.Model

    Friend Class CurrencyRate

        Private _Date As DateTime, _Value As Double

        Public Property [Date] As DateTime
            Get
                Return _Date
            End Get

            Private Set(ByVal value As DateTime)
                _Date = value
            End Set
        End Property

        Public Property Value As Double
            Get
                Return _Value
            End Get

            Private Set(ByVal value As Double)
                _Value = value
            End Set
        End Property

        Public Sub New(ByVal [date] As DateTime, ByVal value As Double)
            Me.Date = [date]
            Me.Value = value
        End Sub
    End Class
End Namespace
