namespace SweetSpot.Models
{
    public class Ingredients
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public string MeasureUnit { get; private set; }
        public string FormattedQuantity 
        {
            get{
                return string.Format("{0} {1}", Quantity, MeasureUnit);
            }
        }       
    }
}