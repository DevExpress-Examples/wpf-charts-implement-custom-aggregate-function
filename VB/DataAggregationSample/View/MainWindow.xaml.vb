Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace DataAggregationSample.View
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	#Region "#CustomAggregateFunctionImplementation"
	Friend Class FinancialAggregateFunction
		Inherits CustomAggregateFunction

		Public Overrides Function Calculate(ByVal groupInfo As GroupInfo) As Double()
			Return New Double() { groupInfo.Values1.Max(), groupInfo.Values1.Min(), groupInfo.Values1.First(), groupInfo.Values1.Last() }
		End Function
	End Class
	#End Region ' #CustomAggregateFunctionImplementation
End Namespace
