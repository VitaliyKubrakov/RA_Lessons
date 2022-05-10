namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of the first Vector (x,y,z):");
            Int32.TryParse(Console.ReadLine(), out var x);
            Int32.TryParse(Console.ReadLine(), out var y);
            Int32.TryParse(Console.ReadLine(), out var z);

            var vec1 = new Vector(x, y, z);
   
            Console.WriteLine("Enter coordinates of the second Vector (x,y,z):");
            Int32.TryParse(Console.ReadLine(), out x);
            Int32.TryParse(Console.ReadLine(), out y);
            Int32.TryParse(Console.ReadLine(), out z);

            var vec2 = new Vector(x, y, z);

            vec1.VectorInfo();
            vec2.VectorInfo();

            var vecSum = vec1 + vec2;
            Console.WriteLine($"vec1 + vec2 = ({vecSum.x}, {vecSum.y}, {vecSum.z})");
            
            var vecSub = vec1 - vec2;
            Console.WriteLine($"vec1 - vec2 = ({vecSub.x}, {vecSub.y}, {vecSub.z})");

            var vecMult = vec1 * vec2;
            Console.WriteLine($"vec1 * vec2 = ({vecMult.x}, {vecMult.y}, {vecMult.z})");

            var scalar = Vector.Scalar(vec1, vec2);
            Console.WriteLine($"(vec1, vec2) = {scalar}");

            var corner = Vector.Corner(vec1, vec2);
            Console.WriteLine($"Corner(vec1, vec2) = {corner}");
        }

    }
}