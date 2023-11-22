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
 *  6. 
 *     
 *  7. 
 *     
 *  8. 
 *     
 */
