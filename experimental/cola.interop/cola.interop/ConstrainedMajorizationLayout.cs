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

public class ConstrainedMajorizationLayout : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ConstrainedMajorizationLayout(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ConstrainedMajorizationLayout obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConstrainedMajorizationLayout() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        colaPINVOKE.delete_ConstrainedMajorizationLayout(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ConstrainedMajorizationLayout(RectPtrVector rs, EdgeVector es, RootCluster clusterHierarchy, double idealLength, SWIGTYPE_p_std__valarrayT_double_t eweights, TestConvergence done, PreIteration preIteration) : this(colaPINVOKE.new_ConstrainedMajorizationLayout__SWIG_0(RectPtrVector.getCPtr(rs), EdgeVector.getCPtr(es), RootCluster.getCPtr(clusterHierarchy), idealLength, SWIGTYPE_p_std__valarrayT_double_t.getCPtr(eweights), TestConvergence.getCPtr(done), PreIteration.getCPtr(preIteration)), true) {
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstrainedMajorizationLayout(RectPtrVector rs, EdgeVector es, RootCluster clusterHierarchy, double idealLength, SWIGTYPE_p_std__valarrayT_double_t eweights, TestConvergence done) : this(colaPINVOKE.new_ConstrainedMajorizationLayout__SWIG_1(RectPtrVector.getCPtr(rs), EdgeVector.getCPtr(es), RootCluster.getCPtr(clusterHierarchy), idealLength, SWIGTYPE_p_std__valarrayT_double_t.getCPtr(eweights), TestConvergence.getCPtr(done)), true) {
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstrainedMajorizationLayout(RectPtrVector rs, EdgeVector es, RootCluster clusterHierarchy, double idealLength, SWIGTYPE_p_std__valarrayT_double_t eweights) : this(colaPINVOKE.new_ConstrainedMajorizationLayout__SWIG_2(RectPtrVector.getCPtr(rs), EdgeVector.getCPtr(es), RootCluster.getCPtr(clusterHierarchy), idealLength, SWIGTYPE_p_std__valarrayT_double_t.getCPtr(eweights)), true) {
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstrainedMajorizationLayout(RectPtrVector rs, EdgeVector es, RootCluster clusterHierarchy, double idealLength) : this(colaPINVOKE.new_ConstrainedMajorizationLayout__SWIG_3(RectPtrVector.getCPtr(rs), EdgeVector.getCPtr(es), RootCluster.getCPtr(clusterHierarchy), idealLength), true) {
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setXConstraints(CompoundConstraintsVector ccsx) {
    colaPINVOKE.ConstrainedMajorizationLayout_setXConstraints(swigCPtr, CompoundConstraintsVector.getCPtr(ccsx));
  }

  public void setYConstraints(CompoundConstraintsVector ccsy) {
    colaPINVOKE.ConstrainedMajorizationLayout_setYConstraints(swigCPtr, CompoundConstraintsVector.getCPtr(ccsy));
  }

  public void setUnsatisfiableConstraintInfo(SWIGTYPE_p_UnsatisfiableConstraintInfos unsatisfiableX, SWIGTYPE_p_UnsatisfiableConstraintInfos unsatisfiableY) {
    colaPINVOKE.ConstrainedMajorizationLayout_setUnsatisfiableConstraintInfo(swigCPtr, SWIGTYPE_p_UnsatisfiableConstraintInfos.getCPtr(unsatisfiableX), SWIGTYPE_p_UnsatisfiableConstraintInfos.getCPtr(unsatisfiableY));
  }

  public void setStickyNodes(double stickyWeight, SWIGTYPE_p_std__valarrayT_double_t startX, SWIGTYPE_p_std__valarrayT_double_t startY) {
    colaPINVOKE.ConstrainedMajorizationLayout_setStickyNodes(swigCPtr, stickyWeight, SWIGTYPE_p_std__valarrayT_double_t.getCPtr(startX), SWIGTYPE_p_std__valarrayT_double_t.getCPtr(startY));
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setScaling(bool scaling) {
    colaPINVOKE.ConstrainedMajorizationLayout_setScaling(swigCPtr, scaling);
  }

  public void setExternalSolver(bool externalSolver) {
    colaPINVOKE.ConstrainedMajorizationLayout_setExternalSolver(swigCPtr, externalSolver);
  }

  public void setAvoidOverlaps(bool horizontal) {
    colaPINVOKE.ConstrainedMajorizationLayout_setAvoidOverlaps__SWIG_0(swigCPtr, horizontal);
  }

  public void setAvoidOverlaps() {
    colaPINVOKE.ConstrainedMajorizationLayout_setAvoidOverlaps__SWIG_1(swigCPtr);
  }

  public void setNonOverlappingClusters() {
    colaPINVOKE.ConstrainedMajorizationLayout_setNonOverlappingClusters(swigCPtr);
  }

  public void setStraightenEdges(SWIGTYPE_p_std__vectorT_straightener__Edge_p_t straightenEdges, double bendWeight, double potBendWeight, bool xSkipping) {
    colaPINVOKE.ConstrainedMajorizationLayout_setStraightenEdges__SWIG_0(swigCPtr, SWIGTYPE_p_std__vectorT_straightener__Edge_p_t.getCPtr(straightenEdges), bendWeight, potBendWeight, xSkipping);
  }

  public void setStraightenEdges(SWIGTYPE_p_std__vectorT_straightener__Edge_p_t straightenEdges, double bendWeight, double potBendWeight) {
    colaPINVOKE.ConstrainedMajorizationLayout_setStraightenEdges__SWIG_1(swigCPtr, SWIGTYPE_p_std__vectorT_straightener__Edge_p_t.getCPtr(straightenEdges), bendWeight, potBendWeight);
  }

  public void setStraightenEdges(SWIGTYPE_p_std__vectorT_straightener__Edge_p_t straightenEdges, double bendWeight) {
    colaPINVOKE.ConstrainedMajorizationLayout_setStraightenEdges__SWIG_2(swigCPtr, SWIGTYPE_p_std__vectorT_straightener__Edge_p_t.getCPtr(straightenEdges), bendWeight);
  }

  public void setStraightenEdges(SWIGTYPE_p_std__vectorT_straightener__Edge_p_t straightenEdges) {
    colaPINVOKE.ConstrainedMajorizationLayout_setStraightenEdges__SWIG_3(swigCPtr, SWIGTYPE_p_std__vectorT_straightener__Edge_p_t.getCPtr(straightenEdges));
  }

  public void moveBoundingBoxes() {
    colaPINVOKE.ConstrainedMajorizationLayout_moveBoundingBoxes(swigCPtr);
  }

  public void run(bool x, bool y) {
    colaPINVOKE.ConstrainedMajorizationLayout_run__SWIG_0(swigCPtr, x, y);
  }

  public void run(bool x) {
    colaPINVOKE.ConstrainedMajorizationLayout_run__SWIG_1(swigCPtr, x);
  }

  public void run() {
    colaPINVOKE.ConstrainedMajorizationLayout_run__SWIG_2(swigCPtr);
  }

  public void straighten(SWIGTYPE_p_std__vectorT_straightener__Edge_p_t arg0, Dim arg1) {
    colaPINVOKE.ConstrainedMajorizationLayout_straighten(swigCPtr, SWIGTYPE_p_std__vectorT_straightener__Edge_p_t.getCPtr(arg0), (int)arg1);
    if (colaPINVOKE.SWIGPendingException.Pending) throw colaPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setConstrainedLayout(bool c) {
    colaPINVOKE.ConstrainedMajorizationLayout_setConstrainedLayout(swigCPtr, c);
  }

}

}
