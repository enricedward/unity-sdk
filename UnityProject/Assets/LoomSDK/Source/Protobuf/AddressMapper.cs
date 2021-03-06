// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/address_mapper.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Loom.Google.Protobuf;
using pbc = global::Loom.Google.Protobuf.Collections;
using pbr = global::Loom.Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Loom.Client.Protobuf {

  /// <summary>Holder for reflection information generated from proto/address_mapper.proto</summary>
  public static partial class AddressMapperReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/address_mapper.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddressMapperReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chpwcm90by9hZGRyZXNzX21hcHBlci5wcm90bxoRcHJvdG8vdHlwZXMucHJv",
            "dG8iRAoUQWRkcmVzc01hcHBlck1hcHBpbmcSFgoEZnJvbRgBIAEoCzIILkFk",
            "ZHJlc3MSFAoCdG8YAiABKAsyCC5BZGRyZXNzIhoKGEFkZHJlc3NNYXBwZXJJ",
            "bml0UmVxdWVzdCJpCiZBZGRyZXNzTWFwcGVyQWRkSWRlbnRpdHlNYXBwaW5n",
            "UmVxdWVzdBIWCgRmcm9tGAEgASgLMgguQWRkcmVzcxIUCgJ0bxgCIAEoCzII",
            "LkFkZHJlc3MSEQoJc2lnbmF0dXJlGAMgASgMIlYKJkFkZHJlc3NNYXBwZXJB",
            "ZGRDb250cmFjdE1hcHBpbmdSZXF1ZXN0EhYKBGZyb20YASABKAsyCC5BZGRy",
            "ZXNzEhQKAnRvGAIgASgLMgguQWRkcmVzcyIjCiFBZGRyZXNzTWFwcGVyUmVt",
            "b3ZlTWFwcGluZ1JlcXVlc3QiOAoeQWRkcmVzc01hcHBlckdldE1hcHBpbmdS",
            "ZXF1ZXN0EhYKBGZyb20YASABKAsyCC5BZGRyZXNzIk8KH0FkZHJlc3NNYXBw",
            "ZXJHZXRNYXBwaW5nUmVzcG9uc2USFgoEZnJvbRgBIAEoCzIILkFkZHJlc3MS",
            "FAoCdG8YAiABKAsyCC5BZGRyZXNzQheqAhRMb29tLkNsaWVudC5Qcm90b2J1",
            "ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Loom.Client.Protobuf.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Loom.Client.Protobuf.AddressMapperMapping), global::Loom.Client.Protobuf.AddressMapperMapping.Parser, new[]{ "From", "To" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Loom.Client.Protobuf.AddressMapperInitRequest), global::Loom.Client.Protobuf.AddressMapperInitRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Loom.Client.Protobuf.AddressMapperAddIdentityMappingRequest), global::Loom.Client.Protobuf.AddressMapperAddIdentityMappingRequest.Parser, new[]{ "From", "To", "Signature" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Loom.Client.Protobuf.AddressMapperAddContractMappingRequest), global::Loom.Client.Protobuf.AddressMapperAddContractMappingRequest.Parser, new[]{ "From", "To" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Loom.Client.Protobuf.AddressMapperRemoveMappingRequest), global::Loom.Client.Protobuf.AddressMapperRemoveMappingRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Loom.Client.Protobuf.AddressMapperGetMappingRequest), global::Loom.Client.Protobuf.AddressMapperGetMappingRequest.Parser, new[]{ "From" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Loom.Client.Protobuf.AddressMapperGetMappingResponse), global::Loom.Client.Protobuf.AddressMapperGetMappingResponse.Parser, new[]{ "From", "To" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Bidirectional mapping between addresses (contracts or accounts) on two different blockchains.
  /// One of the address fields must contain a local address (same chain ID as the contract), while the
  /// other must contain a foreign address.
  /// </summary>
  public sealed partial class AddressMapperMapping : pb::IMessage<AddressMapperMapping> {
    private static readonly pb::MessageParser<AddressMapperMapping> _parser = new pb::MessageParser<AddressMapperMapping>(() => new AddressMapperMapping());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressMapperMapping> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Loom.Client.Protobuf.AddressMapperReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperMapping() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperMapping(AddressMapperMapping other) : this() {
      from_ = other.from_ != null ? other.from_.Clone() : null;
      to_ = other.to_ != null ? other.to_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperMapping Clone() {
      return new AddressMapperMapping(this);
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 1;
    private global::Loom.Client.Protobuf.Address from_;
    /// <summary>
    /// Address on a blockchain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 2;
    private global::Loom.Client.Protobuf.Address to_;
    /// <summary>
    /// Corresponding address on another blockchain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressMapperMapping);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressMapperMapping other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(From, other.From)) return false;
      if (!object.Equals(To, other.To)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (from_ != null) hash ^= From.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
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
      if (from_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(From);
      }
      if (to_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(To);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressMapperMapping other) {
      if (other == null) {
        return;
      }
      if (other.from_ != null) {
        if (from_ == null) {
          from_ = new global::Loom.Client.Protobuf.Address();
        }
        From.MergeFrom(other.From);
      }
      if (other.to_ != null) {
        if (to_ == null) {
          to_ = new global::Loom.Client.Protobuf.Address();
        }
        To.MergeFrom(other.To);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (from_ == null) {
              from_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(from_);
            break;
          }
          case 18: {
            if (to_ == null) {
              to_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(to_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddressMapperInitRequest : pb::IMessage<AddressMapperInitRequest> {
    private static readonly pb::MessageParser<AddressMapperInitRequest> _parser = new pb::MessageParser<AddressMapperInitRequest>(() => new AddressMapperInitRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressMapperInitRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Loom.Client.Protobuf.AddressMapperReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperInitRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperInitRequest(AddressMapperInitRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperInitRequest Clone() {
      return new AddressMapperInitRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressMapperInitRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressMapperInitRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressMapperInitRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class AddressMapperAddIdentityMappingRequest : pb::IMessage<AddressMapperAddIdentityMappingRequest> {
    private static readonly pb::MessageParser<AddressMapperAddIdentityMappingRequest> _parser = new pb::MessageParser<AddressMapperAddIdentityMappingRequest>(() => new AddressMapperAddIdentityMappingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressMapperAddIdentityMappingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Loom.Client.Protobuf.AddressMapperReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperAddIdentityMappingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperAddIdentityMappingRequest(AddressMapperAddIdentityMappingRequest other) : this() {
      from_ = other.from_ != null ? other.from_.Clone() : null;
      to_ = other.to_ != null ? other.to_.Clone() : null;
      signature_ = other.signature_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperAddIdentityMappingRequest Clone() {
      return new AddressMapperAddIdentityMappingRequest(this);
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 1;
    private global::Loom.Client.Protobuf.Address from_;
    /// <summary>
    /// Address on a blockchain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 2;
    private global::Loom.Client.Protobuf.Address to_;
    /// <summary>
    /// Corresponding address on another blockchain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 3;
    private pb::ByteString signature_ = pb::ByteString.Empty;
    /// <summary>
    /// Signature of a hash of the two addresses signed with the key that corresponds to the foreign address
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressMapperAddIdentityMappingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressMapperAddIdentityMappingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(From, other.From)) return false;
      if (!object.Equals(To, other.To)) return false;
      if (Signature != other.Signature) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (from_ != null) hash ^= From.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
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
      if (from_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(From);
      }
      if (to_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(To);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Signature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressMapperAddIdentityMappingRequest other) {
      if (other == null) {
        return;
      }
      if (other.from_ != null) {
        if (from_ == null) {
          from_ = new global::Loom.Client.Protobuf.Address();
        }
        From.MergeFrom(other.From);
      }
      if (other.to_ != null) {
        if (to_ == null) {
          to_ = new global::Loom.Client.Protobuf.Address();
        }
        To.MergeFrom(other.To);
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (from_ == null) {
              from_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(from_);
            break;
          }
          case 18: {
            if (to_ == null) {
              to_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(to_);
            break;
          }
          case 26: {
            Signature = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddressMapperAddContractMappingRequest : pb::IMessage<AddressMapperAddContractMappingRequest> {
    private static readonly pb::MessageParser<AddressMapperAddContractMappingRequest> _parser = new pb::MessageParser<AddressMapperAddContractMappingRequest>(() => new AddressMapperAddContractMappingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressMapperAddContractMappingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Loom.Client.Protobuf.AddressMapperReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperAddContractMappingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperAddContractMappingRequest(AddressMapperAddContractMappingRequest other) : this() {
      from_ = other.from_ != null ? other.from_.Clone() : null;
      to_ = other.to_ != null ? other.to_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperAddContractMappingRequest Clone() {
      return new AddressMapperAddContractMappingRequest(this);
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 1;
    private global::Loom.Client.Protobuf.Address from_;
    /// <summary>
    /// Address on a blockchain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 2;
    private global::Loom.Client.Protobuf.Address to_;
    /// <summary>
    /// Corresponding address on another blockchain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressMapperAddContractMappingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressMapperAddContractMappingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(From, other.From)) return false;
      if (!object.Equals(To, other.To)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (from_ != null) hash ^= From.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
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
      if (from_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(From);
      }
      if (to_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(To);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressMapperAddContractMappingRequest other) {
      if (other == null) {
        return;
      }
      if (other.from_ != null) {
        if (from_ == null) {
          from_ = new global::Loom.Client.Protobuf.Address();
        }
        From.MergeFrom(other.From);
      }
      if (other.to_ != null) {
        if (to_ == null) {
          to_ = new global::Loom.Client.Protobuf.Address();
        }
        To.MergeFrom(other.To);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (from_ == null) {
              from_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(from_);
            break;
          }
          case 18: {
            if (to_ == null) {
              to_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(to_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// TODO
  /// </summary>
  public sealed partial class AddressMapperRemoveMappingRequest : pb::IMessage<AddressMapperRemoveMappingRequest> {
    private static readonly pb::MessageParser<AddressMapperRemoveMappingRequest> _parser = new pb::MessageParser<AddressMapperRemoveMappingRequest>(() => new AddressMapperRemoveMappingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressMapperRemoveMappingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Loom.Client.Protobuf.AddressMapperReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperRemoveMappingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperRemoveMappingRequest(AddressMapperRemoveMappingRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperRemoveMappingRequest Clone() {
      return new AddressMapperRemoveMappingRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressMapperRemoveMappingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressMapperRemoveMappingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressMapperRemoveMappingRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class AddressMapperGetMappingRequest : pb::IMessage<AddressMapperGetMappingRequest> {
    private static readonly pb::MessageParser<AddressMapperGetMappingRequest> _parser = new pb::MessageParser<AddressMapperGetMappingRequest>(() => new AddressMapperGetMappingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressMapperGetMappingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Loom.Client.Protobuf.AddressMapperReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperGetMappingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperGetMappingRequest(AddressMapperGetMappingRequest other) : this() {
      from_ = other.from_ != null ? other.from_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperGetMappingRequest Clone() {
      return new AddressMapperGetMappingRequest(this);
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 1;
    private global::Loom.Client.Protobuf.Address from_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressMapperGetMappingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressMapperGetMappingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(From, other.From)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (from_ != null) hash ^= From.GetHashCode();
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
      if (from_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(From);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressMapperGetMappingRequest other) {
      if (other == null) {
        return;
      }
      if (other.from_ != null) {
        if (from_ == null) {
          from_ = new global::Loom.Client.Protobuf.Address();
        }
        From.MergeFrom(other.From);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (from_ == null) {
              from_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(from_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddressMapperGetMappingResponse : pb::IMessage<AddressMapperGetMappingResponse> {
    private static readonly pb::MessageParser<AddressMapperGetMappingResponse> _parser = new pb::MessageParser<AddressMapperGetMappingResponse>(() => new AddressMapperGetMappingResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressMapperGetMappingResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Loom.Client.Protobuf.AddressMapperReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperGetMappingResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperGetMappingResponse(AddressMapperGetMappingResponse other) : this() {
      from_ = other.from_ != null ? other.from_.Clone() : null;
      to_ = other.to_ != null ? other.to_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressMapperGetMappingResponse Clone() {
      return new AddressMapperGetMappingResponse(this);
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 1;
    private global::Loom.Client.Protobuf.Address from_;
    /// <summary>
    /// Address that was provided in the request
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 2;
    private global::Loom.Client.Protobuf.Address to_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Loom.Client.Protobuf.Address To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressMapperGetMappingResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressMapperGetMappingResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(From, other.From)) return false;
      if (!object.Equals(To, other.To)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (from_ != null) hash ^= From.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
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
      if (from_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(From);
      }
      if (to_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(To);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressMapperGetMappingResponse other) {
      if (other == null) {
        return;
      }
      if (other.from_ != null) {
        if (from_ == null) {
          from_ = new global::Loom.Client.Protobuf.Address();
        }
        From.MergeFrom(other.From);
      }
      if (other.to_ != null) {
        if (to_ == null) {
          to_ = new global::Loom.Client.Protobuf.Address();
        }
        To.MergeFrom(other.To);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (from_ == null) {
              from_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(from_);
            break;
          }
          case 18: {
            if (to_ == null) {
              to_ = new global::Loom.Client.Protobuf.Address();
            }
            input.ReadMessage(to_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
