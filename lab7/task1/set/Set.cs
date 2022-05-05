namespace set;
public class Set
{
    List <char> list;

    public Set() 
    {
        list = new List<char>();
    }
    public Set(int n)
    {
        list = new List<char>(n);
    }
    public Set(int n, char c)
    {
        list = new List<char>(n);
        for (int i=0; i<n; i++)
        {
            list.Add(c);
        }
    }
    public Set (string str)
    {
        list = new List<char>(str.Length);
        for (int i=0; i<str.Length; i++)
        {
            list.Add(str[i]);
        }
    }
    public override string ToString()
    {
        string str = "";
        foreach (char c in list)
        {
            str += c;
        }
        return str;
    }

    public char this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }

    
    public static Set operator +(Set s1, Set s2)
    {
        int count = s1.list.Count;
        foreach (char c in s2.list)
        {
            if (!s1.list.Contains(c))
            {
                count++;
            }
        }
        Set s = new Set(count);
        foreach (char c in s1.list)
        {
            s.list.Add(c);
        }
        foreach (char c in s2.list)
        {
            if (!s1.list.Contains(c))
            {
                s.list.Add(c);
            }
        }
        return s;
    }
    public static Set operator -(Set s1, Set s2)
    {
        int count = s1.list.Count;
        foreach (char c in s2.list)
        {
            if (s1.list.Contains(c))
            {
                count--;
            }
        }
        Set s = new Set(count);
        foreach (char c in s1.list)
        {
            if (!s2.list.Contains(c))
            {
                s.list.Add(c);
            }
        }
        return s;
    }
    public static Set operator *(Set s1, Set s2)
    {
        int count = 0;
        foreach (char c in s1.list)
        {
            if (s2.list.Contains(c))
            {
                count++;
            }
        }
        Set s = new Set(count);
        foreach (char c in s1.list)
        {
            if (s2.list.Contains(c))
            {
                s.list.Add(c);
            }
        }
        return s;
    }
    public static bool operator ==(Set s1, Set s2)
    {
        if (s1.list.Count != s2.list.Count)
        {
            return false;
        }
        for (int i=0; i<s1.list.Count; i++)
        {
            if (s1.list[i] != s2.list[i])
            {
                return false;
            }
        }
        return true;
    }
    public static bool operator !=(Set s1, Set s2)
    {
        if (s1.list.Count != s2.list.Count)
        {
            return true;
        }
        for (int i=0; i<s1.list.Count; i++)
        {
            if (s1.list[i] != s2.list[i])
            {
                return true;
            }
        }
        return false;
    }
    public static bool operator true (Set s)
    {
        return s.list.Count > 0;
    }
    public static bool operator false (Set s)
    {
        return s.list.Count == 0;
    }
    public static implicit operator Set(string str)
    {
        Set s = new Set(str);
        return s;
    }
    public static explicit operator string(Set s)
    {
        return s.ToString();
    }
}
