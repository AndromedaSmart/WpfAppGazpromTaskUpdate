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

        //private PlotModel myModel;
        public PlotModel MyModel
        {
            get;
            private set;
        }
        public Graph(string type, Func<double, double> formula) 
        { 
            this.type = type;
            this.MyModel = new PlotModel { };
            this.MyModel.Series.Add(new FunctionSeries(formula, 0, 10, 0.1));
        }
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