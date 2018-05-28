using System.Linq;
using System.Windows;
using DevExpress.Xpf.Charts;

namespace DataAggregationSample.View {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    #region #CustomAggregateFunctionImplementation
    class FinancialAggregateFunction : CustomAggregateFunction {
        public override double[] Calculate(GroupInfo groupInfo) {
            return new double[] {
                groupInfo.Values1.Max(),
                groupInfo.Values1.Min(),
                groupInfo.Values1.First(),
                groupInfo.Values1.Last()
            };
        }
    }
    #endregion #CustomAggregateFunctionImplementation
}
