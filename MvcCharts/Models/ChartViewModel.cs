namespace MvcCharts.Models
{
    public class ChartViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public VisualizationDataTable DataTable { get; set; }
    }
}