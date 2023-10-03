using Amazon.S3;

X();
Y();
Z(3);

AmazonS3Client s3Client = new();
await s3Client.ListBucketsAsync();

void X()
{
    Console.WriteLine("Laylaylom galiba sana göre sevmeler...");
}

void Y()
{
    Console.WriteLine("Sende başını alıp gitme ne olur, ne olur tut ellerimi...");
}

void Z(int z)
{
    Console.WriteLine(z);
}