// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJob.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyJob.proto</summary>
  public static partial class CompanyJobReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyJob.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyJobReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90b3MvQ29tcGFueUpvYi5wcm90bxIQQ2FyZWVyQ2xvdWQuZ1JQQxof",
            "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxoeZ29vZ2xlL3Byb3Rv",
            "YnVmL3dyYXBwZXJzLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJv",
            "dG8iGAoKSWRSZXF1ZXN0NRIKCgJJZBgBIAEoCSKKAQoKQ29tcGFueUpvYhIK",
            "CgJJZBgBIAEoCRIPCgdDb21wYW55GAIgASgJEjIKDlByb2ZpbGVDcmVhdGVk",
            "GAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBISCgpJc0luYWN0",
            "aXZlGAQgASgIEhcKD0lzQ29tcGFueUhpZGRlbhgFIAEoCCI8CgtDb21wYW55",
            "Sm9icxItCgdDb21wSm9iGAEgAygLMhwuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21w",
            "YW55Sm9iMocDChFDb21wYW55Sm9iU2VydmljZRJLCg1HZXRDb21wYW55Sm9i",
            "EhwuQ2FyZWVyQ2xvdWQuZ1JQQy5JZFJlcXVlc3Q1GhwuQ2FyZWVyQ2xvdWQu",
            "Z1JQQy5Db21wYW55Sm9iEkcKDkdldENvbXBhbnlKb2JzEhYuZ29vZ2xlLnBy",
            "b3RvYnVmLkVtcHR5Gh0uQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9icxJG",
            "Cg1BZGRDb21wYW55Sm9iEh0uQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9i",
            "cxoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJJChBVcGRhdGVDb21wYW55Sm9i",
            "Eh0uQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9icxoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eRJJChBEZWxldGVDb21wYW55Sm9iEh0uQ2FyZWVyQ2xvdWQu",
            "Z1JQQy5Db21wYW55Sm9icxoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eUIaqgIX",
            "Q2FyZWVyQ2xvdWQuZ1JQQy5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.IdRequest5), global::CareerCloud.gRPC.Protos.IdRequest5.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJob), global::CareerCloud.gRPC.Protos.CompanyJob.Parser, new[]{ "Id", "Company", "ProfileCreated", "IsInactive", "IsCompanyHidden" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobs), global::CareerCloud.gRPC.Protos.CompanyJobs.Parser, new[]{ "CompJob" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IdRequest5 : pb::IMessage<IdRequest5>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IdRequest5> _parser = new pb::MessageParser<IdRequest5>(() => new IdRequest5());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequest5> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest5() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest5(IdRequest5 other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequest5 Clone() {
      return new IdRequest5(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IdRequest5);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequest5 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IdRequest5 other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CompanyJob : pb::IMessage<CompanyJob>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CompanyJob> _parser = new pb::MessageParser<CompanyJob>(() => new CompanyJob());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJob> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJob() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJob(CompanyJob other) : this() {
      id_ = other.id_;
      company_ = other.company_;
      profileCreated_ = other.profileCreated_ != null ? other.profileCreated_.Clone() : null;
      isInactive_ = other.isInactive_;
      isCompanyHidden_ = other.isCompanyHidden_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJob Clone() {
      return new CompanyJob(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Company" field.</summary>
    public const int CompanyFieldNumber = 2;
    private string company_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProfileCreated" field.</summary>
    public const int ProfileCreatedFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp profileCreated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ProfileCreated {
      get { return profileCreated_; }
      set {
        profileCreated_ = value;
      }
    }

    /// <summary>Field number for the "IsInactive" field.</summary>
    public const int IsInactiveFieldNumber = 4;
    private bool isInactive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsInactive {
      get { return isInactive_; }
      set {
        isInactive_ = value;
      }
    }

    /// <summary>Field number for the "IsCompanyHidden" field.</summary>
    public const int IsCompanyHiddenFieldNumber = 5;
    private bool isCompanyHidden_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCompanyHidden {
      get { return isCompanyHidden_; }
      set {
        isCompanyHidden_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJob);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJob other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Company != other.Company) return false;
      if (!object.Equals(ProfileCreated, other.ProfileCreated)) return false;
      if (IsInactive != other.IsInactive) return false;
      if (IsCompanyHidden != other.IsCompanyHidden) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (profileCreated_ != null) hash ^= ProfileCreated.GetHashCode();
      if (IsInactive != false) hash ^= IsInactive.GetHashCode();
      if (IsCompanyHidden != false) hash ^= IsCompanyHidden.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      if (profileCreated_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfileCreated);
      }
      if (IsInactive != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsInactive);
      }
      if (IsCompanyHidden != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCompanyHidden);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      if (profileCreated_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfileCreated);
      }
      if (IsInactive != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsInactive);
      }
      if (IsCompanyHidden != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCompanyHidden);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (profileCreated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfileCreated);
      }
      if (IsInactive != false) {
        size += 1 + 1;
      }
      if (IsCompanyHidden != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJob other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.profileCreated_ != null) {
        if (profileCreated_ == null) {
          ProfileCreated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ProfileCreated.MergeFrom(other.ProfileCreated);
      }
      if (other.IsInactive != false) {
        IsInactive = other.IsInactive;
      }
      if (other.IsCompanyHidden != false) {
        IsCompanyHidden = other.IsCompanyHidden;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Company = input.ReadString();
            break;
          }
          case 26: {
            if (profileCreated_ == null) {
              ProfileCreated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProfileCreated);
            break;
          }
          case 32: {
            IsInactive = input.ReadBool();
            break;
          }
          case 40: {
            IsCompanyHidden = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Company = input.ReadString();
            break;
          }
          case 26: {
            if (profileCreated_ == null) {
              ProfileCreated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProfileCreated);
            break;
          }
          case 32: {
            IsInactive = input.ReadBool();
            break;
          }
          case 40: {
            IsCompanyHidden = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CompanyJobs : pb::IMessage<CompanyJobs>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CompanyJobs> _parser = new pb::MessageParser<CompanyJobs>(() => new CompanyJobs());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobs> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobs() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobs(CompanyJobs other) : this() {
      compJob_ = other.compJob_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobs Clone() {
      return new CompanyJobs(this);
    }

    /// <summary>Field number for the "CompJob" field.</summary>
    public const int CompJobFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.CompanyJob> _repeated_compJob_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.CompanyJob.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyJob> compJob_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyJob>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyJob> CompJob {
      get { return compJob_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobs);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobs other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!compJob_.Equals(other.compJob_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= compJob_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      compJob_.WriteTo(output, _repeated_compJob_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      compJob_.WriteTo(ref output, _repeated_compJob_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += compJob_.CalculateSize(_repeated_compJob_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobs other) {
      if (other == null) {
        return;
      }
      compJob_.Add(other.compJob_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            compJob_.AddEntriesFrom(input, _repeated_compJob_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            compJob_.AddEntriesFrom(ref input, _repeated_compJob_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
