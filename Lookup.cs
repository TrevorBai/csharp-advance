/* Lookup:
 *  1. There is a class called Lookup<TKey,TElement> in System.Linq namespace. I guess you probably nevered worry about it or even never
 *     used it ever.
 *  2. It's somewhat similar to Dictionary<TKey,TValue> Class in System.Collections.Generic which represents a collection of keys and values.
 *     We all know a dictionary is a hashmap data structure, so I guess we can call a lookup as a data structure too? Shall we?
 *  3. If so, what data structure is it? Here is some information I found it online, I quote, lookup refers to the process of searching for 
 *     specific information or data within a particular system or database. It involves accessing a set of records or values based on a given 
 *     input or key.
 *  4. It seems like closely related to database. I also quote a stack overflow answer, a Lookup<TKey, TElement> would behave pretty much like 
 *     a (relational) database index on a table without a unique constraint. Use it in the same places you would use the other. 
 *  5. Another fun thing is Lookup<TKey, TElement> doesn't belong to System.Collections.Generic namespace, let that sink in. It seems like to
 *     mean it is NOT commonly used as a collection of things.
 *  ########################################################################################################################################
 *     Lookup<TKey,TElement> is closely related to Enumerable.GroupBy in System.Linq namespace
 *  ########################################################################################################################################
 *  6. public class Lookup<TKey,TElement> : System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey,TElement>>, 
 *     System.Linq.ILookup<TKey,TElement>. As we can tell, it implements a "list" of IGrouping<TKey, TElement>. So it can be enumerable. 
 *  7. ToLookup(keySelector, ValueSelector) is the way to use it. Attension, the ValueSelector would define one value of a list result. In
 *     other words, for a Lookup<char, string> lookup, for each IGrouping<char, string>, the key would be a char, but the sorta value is
 *     a list of string or List<string>. It can be confusing just like GroupBy can be confusing as well.
 *  8. So in simple words, a lookup<char, string> would include a list of IGrouping<char, string> where inside it, it has a char key, and 
 *     a list of string (because it groups). But the generic still is <char, string> not <char, IEnumerable<string>> if that makes sense.
 *     That's a key difference between lookup and dictionary. It kinda like a lookup is a grouped dictionary.
 */
