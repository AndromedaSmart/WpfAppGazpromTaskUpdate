using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System;
using OxyPlot;
using OxyPlot.Series;

namespace WpfAppGazpromTask
{
    public class ApplicationViewModel
    {
        private Graph selectedTypeOfGraph;

        // public PlotModel MyModel { get; private set; }

        public ObservableCollection<Graph> TypesOfGraphs { get; set; }
        public Graph SelectedTypeOfGraph
        {
            get { return selectedTypeOfGraph; }
            set
            {
                selectedTypeOfGraph = value;
                OnPropertyChanged("selectedTypeOfGraph");
            }
        }

        public ApplicationViewModel()
        {
            TypesOfGraphs = new ObservableCollection<Graph>
            {
                new Graph ("Square Root function", Math.Sqrt),
                new Graph ("Sinusoid function", Math.Sin),
                new Graph ("Hyperbolic cosine function", Math.Cosh),
            };

            // this.MyModel = new PlotModel { Title = "Sinusoid function" };
            // this.MyModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}