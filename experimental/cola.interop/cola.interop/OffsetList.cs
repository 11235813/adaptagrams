/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.adaptagrams.cola {

using System;
using System.Runtime.InteropServices;

public class OffsetList : IDisposable, System.Collections.IEnumerable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OffsetList(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(OffsetList obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~OffsetList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        colaPINVOKE.delete_OffsetList(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public OffsetList(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (OffsetPair element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public OffsetPair this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(System.Array array) {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(System.Array array, int arrayIndex) {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, System.Array array, int arrayIndex, int count) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  // Type-safe version of IEnumerable.GetEnumerator
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new OffsetListEnumerator(this);
  }

  public OffsetListEnumerator GetEnumerator() {
    return new OffsetListEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class OffsetListEnumerator : System.Collections.IEnumerator {
    private OffsetList collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public OffsetListEnumerator(OffsetList collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public OffsetPair Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (OffsetPair)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }
  }

  public void Clear() {
    colaPINVOKE.OffsetList_Clear(swigCPtr);
  }

  public void Add(OffsetPair x) {
    colaPINVOKE.OffsetList_Add(swigCPtr, OffsetPair.getCPtr(x));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = colaPINVOKE.OffsetList_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = colaPINVOKE.OffsetList_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    colaPINVOKE.OffsetList_reserve(swigCPtr, n);
  }

  public OffsetList() : this(colaPINVOKE.new_OffsetList__SWIG_0(), true) {
  }

  public OffsetList(int capacity) : this(colaPINVOKE.new_OffsetList__SWIG_1(capacity), true) {
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  private OffsetPair getitemcopy(int index) {
    OffsetPair ret = new OffsetPair(colaPINVOKE.OffsetList_getitemcopy(swigCPtr, index), true);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private OffsetPair getitem(int index) {
    OffsetPair ret = new OffsetPair(colaPINVOKE.OffsetList_getitem(swigCPtr, index), false);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, OffsetPair val) {
    colaPINVOKE.OffsetList_setitem(swigCPtr, index, OffsetPair.getCPtr(val));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(OffsetList values) {
    colaPINVOKE.OffsetList_AddRange(swigCPtr, OffsetList.getCPtr(values));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public OffsetList GetRange(int index, int count) {
    IntPtr cPtr = colaPINVOKE.OffsetList_GetRange(swigCPtr, index, count);
    OffsetList ret = (cPtr == IntPtr.Zero) ? null : new OffsetList(cPtr, true);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, OffsetPair x) {
    colaPINVOKE.OffsetList_Insert(swigCPtr, index, OffsetPair.getCPtr(x));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, OffsetList values) {
    colaPINVOKE.OffsetList_InsertRange(swigCPtr, index, OffsetList.getCPtr(values));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    colaPINVOKE.OffsetList_RemoveAt(swigCPtr, index);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    colaPINVOKE.OffsetList_RemoveRange(swigCPtr, index, count);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public static OffsetList Repeat(OffsetPair value, int count) {
    IntPtr cPtr = colaPINVOKE.OffsetList_Repeat(OffsetPair.getCPtr(value), count);
    OffsetList ret = (cPtr == IntPtr.Zero) ? null : new OffsetList(cPtr, true);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    colaPINVOKE.OffsetList_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    colaPINVOKE.OffsetList_Reverse__SWIG_1(swigCPtr, index, count);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, OffsetList values) {
    colaPINVOKE.OffsetList_SetRange(swigCPtr, index, OffsetList.getCPtr(values));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
