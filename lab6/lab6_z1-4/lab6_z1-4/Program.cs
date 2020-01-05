using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_z1_4
{
    class Tree
    {
        public Tree(string n, int a)
        {
            name = n;
            age = a;
        }
        public string name;
        public int age;
    }
    class Fir : Tree
    {
        public Fir(string n, int a) : base(n, a) { }

        List<Bauble> bauble_tab = new List<Bauble>();
        class Bauble
        {
            public Bauble(string c, string t)
            {
                type = t;
                colour = c;
            }
            public string type;
            public string colour;
        }
        public void add_bauble(string colour, string type)
        {
            Bauble new_bauble = new Bauble(colour, type);
            bauble_tab.Add(new_bauble);
        }
        public void delete_bauble(int index)
        {
            bauble_tab.RemoveAt(index);
        }
        public string give_colour(int index)
        {
            return bauble_tab[index].colour;
        }
        public int give_index(string c)
        {
            int idx = 0;
            for (int ptr = 0; ptr < bauble_tab.Count; ptr++)
            {
                idx++;
                if (bauble_tab[ptr].colour == c)
                    break;
            }
            return idx;
        }
        public int count_colour(string colour)
        {
            int count = 0;
            for (int ptr = 0; ptr < bauble_tab.Count; ptr++)
            {
                if (bauble_tab[ptr].colour == colour)
                    count++;
            }
            return count;
        }
        public void change_colour(int i, string c)
        {
            bauble_tab[i].colour = c;
        }
        public string give_shape_and_colour(int i)
        {
            return bauble_tab[i].colour + " " + bauble_tab[i].type;
        }
    }
    class Christmas_tree : Fir
    {
        public Christmas_tree(string n, int a) : base(n, a) { }
        public string this[int index1]
        {
            get
            {
                return give_colour(index1);
            }
        }
        public int this[string index2]
        {
            get
            {
                return count_colour(index2);
            }
        }
        public int this[int index3, string c]
        {
            get
            {
                change_colour(index3, c);
                return 1;
            }
        }
    }
    class Christmas_tree_A : Christmas_tree
    {
        public Christmas_tree_A(string n, int a) : base(n, a) { }
        public string BaubleColor(int idx)
        {
            return this[idx];
        }
        public int this[string index1]
        {
            get
            {
                return this.give_index(index1);
            }
        }

    }

    class Christmas_tree_B : Christmas_tree_A
    {
        public Christmas_tree_B(string n, int a) : base(n, a) { }

        public string this[int index1]
        {
            get
            {
                return give_shape_and_colour(index1);
            }
        }
    }
    sealed class Christmas_tree_C : Christmas_tree_B
    {
        public Christmas_tree_C(string n, int a) : base(n, a) { }
    }


    /*
    public class Christmas_tree_D : Christmas_tree_C
    {
        public Christmas_tree_D(string n, int a) : base(n, a) { } dziedziczenie po klasie zapieczetowanej skutkuje bledem
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
            Christmas_tree cht = new Christmas_tree("tree1", 30);
            Christmas_tree_A chta = new Christmas_tree_A("tree1a", 30);
            Christmas_tree_B chtb = new Christmas_tree_B("tree1b", 30);
            cht.add_bauble("red", "star");
            cht.add_bauble("blue", "rectangular");
            chta.add_bauble("green", "star");
            chta.add_bauble("black", "rectangular");
            chtb.add_bauble("yellow", "circular");
            chtb.add_bauble("voilet", "square");
            Console.WriteLine(cht[0]);
            Console.WriteLine(cht["blue"]);
            _ = cht[0, "grey"];
            Console.WriteLine(cht[0]);
            Console.WriteLine(chta[0]);
            Console.WriteLine(chtb[0]);
            Console.WriteLine(((Christmas_tree_A)chtb)[0]);
        }
    }
}
