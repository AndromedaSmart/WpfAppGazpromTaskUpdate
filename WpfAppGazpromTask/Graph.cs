using OxyPlot;
using OxyPlot.Series;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppGazpromTask
{
    public class Graph
    {
        private string type;

        // private PlotModel myModel;
        /* public PlotModel MyModel
        {
            get { return MyModel; }
            private set
            {
                this.MyModel = new PlotModel { Title = "Sinusoid function" };
                this.MyModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            }
        }*/

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}