using Amazon.S3.Model;
using System.Runtime.CompilerServices;

namespace Interceptor.Example
{
    static public class CodeGenerator
    {
        [InterceptsLocation(@"C:\Users\Gencay\Desktop\Interceptor.Example\Interceptor.Example\Program.cs", line: 3, column: 1)]
        [InterceptsLocation(@"C:\Users\Gencay\Desktop\Interceptor.Example\Interceptor.Example\Program.cs", line: 4, column: 1)]
        static public void XInterceptor()
        {
            Console.WriteLine("Doldur be meyhaneci, boş kalmasın kadehim...");
        }

        [InterceptsLocation(@"C:\Users\Gencay\Desktop\Interceptor.Example\Interceptor.Example\Program.cs", line: 5, column: 1)]
        static public void ZInterceptor(int zParam)
        {
            Console.WriteLine(zParam * 3);
        }

        [InterceptsLocation(@"C:\Users\Gencay\Desktop\Interceptor.Example\Interceptor.Example\Program.cs", line: 8, column: 16)]
        static public async Task<ListBucketsResponse> ListBucketsAsyncInterceptor(CancellationToken cancellationToken = default(CancellationToken))
        {
            Console.WriteLine("List Buckets Async Interceptor");
            return null;
        }


    }
}
