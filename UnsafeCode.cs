/* 
 *  ########################################################################################################################################
 *     You can write C code within a C# program
 *  ########################################################################################################################################
 *  ########################################################################################################################################
 *     History
 *  ########################################################################################################################################
 *  1. When I am writing a code using Substring method in System.String class, I got an exception saying kinda 
 *     ArgumentOutOfRange_IndexLength. Then I have to dive into the method implementation itself to understand what's going on.
 *  2. The implementation is in decompiled String class decompiled with ICSharpCode.Decompiler where the compiled binary is in 
 *     mscorlib.dll.
 *  3. In the Substring(int startIndex, int length) method, there are a chain of if statements, which is pretty good written.
 *     Compared to using if, else if, else if, ... But the code also looks quite cluttering, or what new developer wrote. I
 *     guess there might not be a better way to write them tho.
 *  4. After a chain of if statements, it points to another method InternalSubString() with capital S in String, which is
 *     interesting.
 *  5. That method is very unusual which has pointer type or very much like C code. Then it is where I started to figure
 *     out what's going on here.
 *  ########################################################################################################################################
 *     unsafe modifier
 *  ########################################################################################################################################
 *  6. Under unsafe context, user can declare a pointer type such as char* p, which is pretty strange right? It is just C code.
 *  7. The type specified before the * in a pointer type (such as char in char* p) is called the referent type of the pointer type. 
 *     It represents the type of the variable to which a value of the pointer type points. 
 *  8. Unlike references (values of reference types), pointers are not tracked by the garbage collector — the garbage collector has 
 *     no knowledge of pointers and the data to which they point. In other words, you write pointer code, it would not be able to
 *     automatically cleaned up, you have to manage your memory manually like writing C/C++ code.
 *  ########################################################################################################################################
 *     fixed statement
 *  ########################################################################################################################################
 *  9. Fixed variables reside in storage locations that are unaffected by operation of the garbage collector. On the other hand, moveable 
 *     variables reside in storage locations that are subject to relocation or disposal by the garbage collector. In other words, fixed is
 *     fixed, or stubburn, you can't modify me (by the garbage collector).
 * 10. Examples of fixed variables include local variables, value parameters, and variables created by dereferencing pointers. Examples of 
 *     moveable variables include fields in objects and elements of arrays.
 * 11. The fixed statement guarantees that the garbage collector doesn't relocate or dispose of the containing object instance during the 
 *     execution of the statement body. In other words, after executing the statement body, it's not fixed any more, or it can be moveable
 *     or maybe garbage collected?
 * 12. You can allocate memory on the stack, where it's not subject to garbage collection. In other words, garbage collection is taking 
 *     effect on heap.
 * 13. The fixed statement prevents the garbage collector from relocating a moveable variable and declares a pointer to that variable. 
 *     The address of a fixed, or pinned, variable doesn't change during execution of the statement. You can use the declared pointer ONLY
 *     inside the corresponding fixed statement (outside of it, the declared pointer would be undefined/ maybe garbage collected). 
 *     The declared pointer is readonly and can't be modified.
 *  ########################################################################################################################################
 *     Conclusion and insight
 *  ########################################################################################################################################
 * 14. You can definitely write C/C++ code in C# but why? Sometimes, you might need manipulate pointers or deal with something low enough to
 *     operating system or maybe write some time complexity sensitive code/very performant code. Then use unsafe modifier, you can do it.
 * 15. Some string operations such as Substring() in C# are actually implemented in C code. Why? Maybe performance concern. Imo, some basic
 *     string/array operations are implemented in C for every other language such as python/java/c#. Maybe one level below C is assembly.
 * 16. One insight I can draw is C# is a higher wrapper language which eases developer/user to code, but under the hood, it's an interface to C.
 *     Or just like Lex Fridman says, I quote, "Python is an API to C. C is an API to assembly."
 * 17. Another insight I have drawn is when you know (maybe no need to understand) some basics of string/array operations in C, it seems like 
 *     a lot of high level languages are just using the same C implementation. It's not super diverse but rather condense.
 */
