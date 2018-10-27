using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Report_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> data = new List<Question>();

            data.Add(new Question());
            data[0].Description = "Test Vraag 1";
            data[0].Answer.Add(new Answer("Nulla facilisi.Vivamus non rhoncus felis.Proin sed imperdiet nibh, hendrerit posuere massa.Morbi fringilla velit eu risus ultricies, eget pellentesque justo mollis.Pellentesque non eleifend ligula, egestas dapibus tortor.Nullam molestie dictum ipsum semper placerat.Nam semper maximus tincidunt.Aenean molestie magna ex, quis fermentum tellus efficitur ac.Nam commodo purus quis turpis ultrices, ac pretium augue pretium.Nulla eu imperdiet orci.Nunc non tempus purus, nec eleifend libero.Fusce in sapien velit.Ut non facilisis arcu.Nulla nisl velit, sagittis in ornare non, vulputate ac sapien.Morbi sollicitudin ultrices urna, nec iaculis enim cursus a. ", 5, 1));
            data[0].Answer.Add(new Answer("Phasellus orci mi, sodales eu ante a, condimentum sagittis ante. Nullam eget facilisis lectus. Fusce ullamcorper scelerisque purus, ut gravida orci ullamcorper eget. Suspendisse et leo eget lorem fermentum tempor. Morbi felis libero, dignissim eget suscipit non, gravida a nulla. Nunc vel sagittis dolor. Proin fermentum malesuada placerat. Maecenas sollicitudin tellus lobortis tincidunt pulvinar. Phasellus non est felis. Donec convallis diam eu accumsan lobortis. ", 4, 2));
            data.Add(new Question());
            data[1].Description = "Test Vraag 2";
            data[1].Answer.Add(new Answer("Nulla facilisi.Vivamus non rhoncus felis.Proin sed imperdiet nibh, hendrerit posuere massa.Morbi fringilla velit eu risus ultricies, eget pellentesque justo mollis.Pellentesque non eleifend ligula, egestas dapibus tortor.Nullam molestie dictum ipsum semper placerat.Nam semper maximus tincidunt.Aenean molestie magna ex, quis fermentum tellus efficitur ac.Nam commodo purus quis turpis ultrices, ac pretium augue pretium.Nulla eu imperdiet orci.Nunc non tempus purus, nec eleifend libero.Fusce in sapien velit.Ut non facilisis arcu.Nulla nisl velit, sagittis in ornare non, vulputate ac sapien.Morbi sollicitudin ultrices urna, nec iaculis enim cursus a. ", 3, 1));
            data[1].Answer.Add(new Answer("Phasellus orci mi, sodales eu ante a, condimentum sagittis ante. Nullam eget facilisis lectus. Fusce ullamcorper scelerisque purus, ut gravida orci ullamcorper eget. Suspendisse et leo eget lorem fermentum tempor. Morbi felis libero, dignissim eget suscipit non, gravida a nulla. Nunc vel sagittis dolor. Proin fermentum malesuada placerat. Maecenas sollicitudin tellus lobortis tincidunt pulvinar. Phasellus non est felis. Donec convallis diam eu accumsan lobortis. ", 1, 2));

            PDF_Generator generator = new PDF_Generator();
            generator.Generate(data);

        }
    }
}
