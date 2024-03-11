using OpenAI_API;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var api = new OpenAIAPI("ENTER THE KEY HERE");

        var request = new OpenAI_API.Images.ImageGenerationRequest
        {
            Prompt = "A cut kitten in a basket"
        };

        var response = await api.ImageGenerations.CreateImageAsync(request);
        Console.WriteLine("Image URL: {0}", response.Data[0].Url);
    }
}