public static int BinarySearch(Array a, object v);
/*
 Returns the index of the first match.
If v is not found, returns a negative value.
The array must be sorted and one-dimensional.*/
public static int BinarySearch(Array a, object v, IComparer comp);
/*
Searches the array a for v, using the comparison method comp.
Returns the index of the first match.
If v is not found, returns a negative value.
The array must be sorted and one-dimensional.
*/
public static int BinarySearch(Array a, int start, int count, object v);

/*
 Searches a portion of the array a for the value v.
The search begins at the index 'start' and is restricted to 'count' elements.
Returns the index of the first match.
If v is not found, returns a negative value.
The array must be sorted and one-dimensional.*/

public static int BinarySearch(Array a, int start, int count, object v, IComparer comp);
/*
Searches a portion of the array a for the value v, using the comparison method comp.
The search begins at the index start and is restricted to count elements.
Returns the index of the first match.
If v is not found, returns a negative value.
The array must be sorted and one-dimensional.
*/
public static void Clear(Array a, int start, int count);
/*
Sets the elements of a to zero.
The elements begin at the index specified by start and the length is count.
*/
public virtual object Clone();
/*
Clone this array.
The both copy refer to the same elements.
This is called a "shallow copy."
Changes to the elements affect both arrays.
*/
public static void Copy(Array source, Array dest, int count);
/*
Beginning at the start of each array, copies count elements from source to dest.
Copy() makes a "shallow copy".
Both arrays will refer to the same reference type elements.
*/
public static void Copy(Array source, int srcStart, Array dest, int destStart, int count);
/*
Copies count elements from source[srcStart] to dest[destStart].
Copy() makes a "shallow copy".
Both arrays will refer to the same reference type elements.
*/
public virtual void CopyTo(Array dest, int start);
    /*
Copies the elements of the invoking array to dest, beginning at dest[start].
*/
public static Array CreateInstance(Type t, int size);

/*
Returns a one-dimensional array that contains size elements of type t.
*/

public static Array CreateInstance(Type t, int size1, int size2);

/*
Returns a size1-by-size2 two-dimensional array.
Each element is of type t.
*/

public static Array CreateInstance(Type t, int size1, int size2, int size3);

/*
Returns a size1-by-size2-by-size3 three-dimensional array.
Each element is of type t.
*/
public static Array CreateInstance(Type t, int[] sizes);
/*
Returns a multi-dimensional array.
The dimensions is specified in sizes.
Each element is of type t.
*/
public static Array CreateInstance(Type t, int[] sizes, int[] startIndexes);
/*
Returns a multi-dimensional array.
The dimensions is specified in sizes.
Each element is of type t.
The starting index of each dimension is startIndexes.
It is possible to create arrays that begin at some index other than zero.
*/
public override bool Equals(object v);
/*
Returns true if the value of the invoking object equals the value of v.
*/
public virtual IEnumerator GetEnumerator();
/*
Returns an enumerator object for the array.
An enumerator enables you to cycle through an array.
*/
public int GetLength(int dim);
/*
Returns the length at the specified dimension.
The dimension is zero-based.
To get the length of the first dimension, pass 0.
To obtain the length of the second dimension, pass 1.
*/
public int GetLowerBound(int dim);
/*
Returns the first index of the specified dimension, which is usually zero.
The parameter dim is zero-based.
To get the start index of the first dimension, pass 0.
To obtain the start index of the second dimension, pass 1.
*/
public override int GetHashCode();
/*
Returns the hash code for the invoking object.
*/
public TypeCode GetTypeCode();
/*
Returns the TypeCode enumeration value for Array, which is TypeCode.Array.
*/
public int GetUpperBound(int dim);
/*Returns the last index of the specified dimension.
The parameter dim is zero-based.
To get the last index of the first dimension, pass 0.
To obtain the last index of the second dimension, pass 1.
*/
public object GetValue(int idx);
/*
Returns the value of the element at index idx.
The array must be one-dimensional.
*/
public object GetValue(int idx1, int idx2);
/*
Returns the value of the element at[idx1, idx2].
The array must be two-dimensional.
*/
public object GetValue(int idx1, int idx2, int idx3);
/*
Returns the value of the element at[idx1, idx2, idx3].
The array must be three- dimensional.
*/
public object GetValue(int[] idxs);
/*
Returns the value of the element at the specified indices.
The array must have as many dimensions as idxs has elements.
*/
public static int IndexOf(Array a, object v);
/*
Returns the index of the first element within the one-dimensional array a that has the value specified by v.
Returns -1 if the value is not found.
*/
public static int IndexOf(Array a, object v, int start);
/*
Returns the index of the first element within the one-dimensional array a that has the value specified by v.
The search begins at a[start].
Returns -1 if the value is not found.
*/
public static int IndexOf(Array a, object v, int start, int count);
/*
Returns the index of the first element within the one-dimensional array a that has the value specified by v.
The search begins at a[start].
The search runs for count elements.
Returns -1 if the value is not found.
*/
public void Initialize();
/*
Initializes each element in the invoking array.
It calls the element's default constructor.
This method can be used only on arrays of value types.
*/
public static int LastIndexOf(Array a, object v);
/*
Returns the index of the last element within the one-dimensional array a that has the value specified by v.
Returns -1 if the value is not found.
*/
public static int LastIndexOf(Array a, object v, int start);
/*
The search proceeds in reverse order, beginning at a[start] and stopping at a[0].
Returns -1 if the value is not found.
*/
public static int LastIndexOf(Array a, object v, int start, int count);

/*
The search proceeds in reverse order, beginning at a[start] and running for count elements.
Returns -1 if the value is not found within the specified range.
*/

public static void Reverse(Array a);
/*
Reverses the elements in a.
*/
public static void Reverse(Array a, int start, int count);
/*
Reverses a range of elements in a.
The range reversed begins at a[start] and runs for count elements.

*/
public void SetValue(object v, int idx);
/*
The array must be one-dimensional.
*/
public void SetValue(object v, int idx1, int idx2);
/*
Sets the value at indices[idx1, idx2].
The array must be two-dimensional.
*/
public void SetValue(object v, int idx1, int idx2, int idx3);
  /*
Sets the value at indices[idx1, idx2, idx3].
The array must be three-dimensional.
 */
public void SetValue(object v, int[] idxs);

/*
Sets the value of the element at the specified indices within the invoking array to v.
The array must have as many dimensions as idxs has elements.
 */

public static void Sort(Array a);
/*
Sorts a into ascending order.
The array must be one-dimensional.
*/
public static void Sort(Array a, IComparer comp);
/*
The array must be one-dimensional.
*/
public static void Sort(Array k, Array v);
/*
Sorts a pair of one-dimensional arrays into ascending order.
The k array contains the sort keys.
The v array contains the values linked to those keys.
The two arrays contain key/value pairs.
After the sort, both arrays are in ascending key order.
*/
public static void Sort(Array k, Array v, IComparer comp);
/*
Sorts a pair of one-dimensional arrays into ascending order using the comparison method specified by comp.
The k array contains the sort keys.
The v array contains the values linked to those keys.
The two arrays contain key/value pairs.
After the sort, both arrays are in ascending key order.
*/
public static void Sort(Array a, int start, int count);
/*
Sorts a range of a into ascending order.
The range begins at a[start] and runs for count elements.
The array must be one-dimensional.
*/
public static void Sort(Array a, int start, int count, IComparer comp);
/*
Sorts a range of a into ascending order using the comparison method specified by comp.
The range begins at a[start] and runs for count elements.
The array must be one-dimensional.
*/
public static void Sort(Array k, Array v, int start, int count);

/*
Sorts a range within a pair of one-dimensional arrays into ascending order.
Within both arrays, the range to sort begins at the index passed in start and runs for count elements.
The k array contains the sort keys.
The v array contains the values linked to those keys.
The two arrays contain key/value pairs.
After the sort, both ranges are in ascending-key order.
*/

public static void Sort(Array k, Array v, int start, int count, IComparer comp);

/*
Sorts a range within a pair of one- dimensional arrays into ascending order using the comparison method specified by comp.
Within both arrays, the range to sort begins at the index passed in start and runs for count elements.
The k array contains the sort keys.
The v array contains the values linked to those keys.
The two arrays contain key/value pairs.
After the sort, both ranges are in ascending-key order.
*/