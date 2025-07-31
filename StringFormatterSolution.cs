using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{


    public class StringFormatter
    {

        //improved code
        public static string ToCommaSeparatedList(string[] items, string quote) // fixed typo
        {
            if (items == null || items.Length < 1) // error handling - checking for nulls and empty items
            {
                return string.Empty;
            }

            StringBuilder qry = new StringBuilder(); // initialising qry 

            for (int i = 0; i < items.Length; i++)
            {
                if (i > 0)
                {
                    qry.Append(", ");  // universal comma logic
                }

                qry.Append(string.Format("{0}{1}{0}", quote, items[i])); // appending subsiquent items to the string
            }

            return qry.ToString(); 

        }
    }
}
