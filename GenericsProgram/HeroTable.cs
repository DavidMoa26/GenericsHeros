using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    internal class HeroTable<T> where T : Hero
    {
        public T[]? Heroes { get; set; }
        public HeroTable(int size)
        {
            Heroes = new T[size];
        }
        public void Set(int index,T hero)
        {
            if (Heroes == null)
                throw new ArgumentNullException("Array is null");
            if (Heroes[index] != null)
                throw new IndexNotAvailable("Index not available");
            Heroes[index] = hero;
        }
        public void Delete(int index)
        {
            if (Heroes == null)
                throw new ArgumentNullException("Array is null");
            if (Heroes[index] == null)
                throw new IndexNotAvailable("Index not available");
            Heroes[index] = null;
        }
        public int Count()
        {
            int counter = 0;
            foreach (T obj in Heroes)
            {
                if(obj!=null)
                    counter++; 
            }
            return counter;
        }
        public T[] GetHeros()
        {
            T[] NewArrOfHeros = new T[Count()];
            for (int i = 0,j=0; i < Heroes.Length; i++)
            {
                if (Heroes[i] != null)
                {
                    NewArrOfHeros[j] = Heroes[i];
                    j++;
                }
            }
            return NewArrOfHeros;
        }
        public T this[int index]
        {
            get
            {
                if(Count() == 0)
                    return null;
                int Index = RotateIndex(index);
                if(Heroes[Index]==null)
                {
                    for (int i = 0; i < Heroes.Length; i++)
                    {
                        if (Heroes[Heroes.Length - 1] == Heroes[i] && Heroes[Heroes.Length - 1] == null)
                            i = 0;
                        if (Heroes[i] != null)
                            return Heroes[i];
                    }
                }
                return Heroes[Index];                    
            }
        }
        public int RotateIndex(int index)
        {
            if (index < 0)
                index = 0;
            if(index > Heroes.Length-1)
                while(index > Heroes.Length-1)
                    index-=Heroes.Length;
            return index;
        }
    }
}
