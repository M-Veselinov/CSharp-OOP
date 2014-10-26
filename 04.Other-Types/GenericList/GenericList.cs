using System;

[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct |
                       System.AttributeTargets.Interface |
                       System.AttributeTargets.Enum |
                       System.AttributeTargets.Method)
]
public class Version : System.Attribute
{
    public double version;

    public Version(double version)
    {
        this.version = version;
    }
}

public class GenericList<T>
{
    public double version = 1.2;
    public const int defaultLength = 16;
    public int arrayLength;
    public T element;
    public T[] arr;
    public T[] result;
    public int index = 1;
    public GenericList(T element)
    {
        this.element = element;
        this.arrayLength = defaultLength;
        this.arr = new T[defaultLength];
        this.arr[0] = element;
    }
    public GenericList(T element,int length)
    {
        this.element = element;
        this.arrayLength = length;
        this.arr = new T[length];
        this.arr[0] = element;
    }
    public T Add(T element)
    {
        if (index < arrayLength)
        {
            arr[index] = element;
            index++;
        }
        return arr[index];
    }
    public T AccessByIndex(int index)
    {
        return arr[index];
    }
    public T[] Remove(int index)
    {
        result = new T[arr.Length - 1];
        int newCounter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == index)//it is assumed at this point i will match index once only
            {
                continue;
            }
            result[newCounter] = arr[i];
            newCounter++;
            arrayLength = arr.Length;
        }
        arr = new T[result.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = result[i];
        }
        return arr;
    }
    public T Insert(T element,int ind)
    {
        if (ind < arrayLength)
        {
            this.arr[ind+1] = element;
        }
            return arr[ind];
    }
    public T[] Clear(T value)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = value;
        }
        return arr;
    }
    public int Find(T element)
    {
        int p = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(element))
            {
                p = i;
            }
        }
        return p;
    }
}
    class Program
    {
        static void Main()
        {
            GenericList<int> mario = new GenericList<int>(5,10);
            int index = mario.Find(10);
            Console.WriteLine(index);
        }
    }

