using static System.Math;

namespace Lesson5

{
    public class Vector
    {
        public int x, y, z;
        
        public Vector()
        {
            x = 0;
            y = 0;  
            z = 0;  
        }
        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void VectorInfo()
        {
            Console.WriteLine($"({x}, {y}, {z})");
        }

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z);
        }

        public static Vector operator -(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
        }

        public static Vector operator *(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.y * vec2.z - vec1.z * vec2.y, vec1.z * vec2.x - vec1.x * vec2.z, vec1.x * vec2.y - vec1.y * vec2.x);
        }

        public static int Scalar(Vector vec1, Vector vec2)
        {
            return vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;
        }

        public static double Length(Vector vec1)
        {
            return Math.Sqrt(vec1.x * vec1.x + vec1.y * vec1.y + vec1.z * vec1.z);
        }
        
        public static double Corner(Vector vec1, Vector vec2)
        {
            return Scalar(vec1, vec2) / (Math.Abs(Length(vec1)) * Math.Abs(Length(vec2)));
        }
    }
}
