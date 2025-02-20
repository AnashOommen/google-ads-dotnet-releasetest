// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/offline_user_data_job_failure_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/offline_user_data_job_failure_reason.proto</summary>
  public static partial class OfflineUserDataJobFailureReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/offline_user_data_job_failure_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobFailureReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9vZmZsaW5lX3VzZXJf",
            "ZGF0YV9qb2JfZmFpbHVyZV9yZWFzb24ucHJvdG8SHWdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY5LmVudW1zIq0BCiNPZmZsaW5lVXNlckRhdGFKb2JGYWlsdXJl",
            "UmVhc29uRW51bSKFAQofT2ZmbGluZVVzZXJEYXRhSm9iRmFpbHVyZVJlYXNv",
            "bhIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIlCiFJTlNVRkZJQ0lF",
            "TlRfTUFUQ0hFRF9UUkFOU0FDVElPTlMQAhIdChlJTlNVRkZJQ0lFTlRfVFJB",
            "TlNBQ1RJT05TEANC+QEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5l",
            "bnVtc0IkT2ZmbGluZVVzZXJEYXRhSm9iRmFpbHVyZVJlYXNvblByb3RvUAFa",
            "Qmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92OS9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlY5LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlcRW51",
            "bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.OfflineUserDataJobFailureReasonEnum), global::Google.Ads.GoogleAds.V9.Enums.OfflineUserDataJobFailureReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing reasons why an offline user data job
  /// failed to be processed.
  /// </summary>
  public sealed partial class OfflineUserDataJobFailureReasonEnum : pb::IMessage<OfflineUserDataJobFailureReasonEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OfflineUserDataJobFailureReasonEnum> _parser = new pb::MessageParser<OfflineUserDataJobFailureReasonEnum>(() => new OfflineUserDataJobFailureReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OfflineUserDataJobFailureReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Enums.OfflineUserDataJobFailureReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobFailureReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobFailureReasonEnum(OfflineUserDataJobFailureReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OfflineUserDataJobFailureReasonEnum Clone() {
      return new OfflineUserDataJobFailureReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJobFailureReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OfflineUserDataJobFailureReasonEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OfflineUserDataJobFailureReasonEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OfflineUserDataJobFailureReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The failure reason of an offline user data job.
      /// </summary>
      public enum OfflineUserDataJobFailureReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The matched transactions are insufficient.
        /// </summary>
        [pbr::OriginalName("INSUFFICIENT_MATCHED_TRANSACTIONS")] InsufficientMatchedTransactions = 2,
        /// <summary>
        /// The uploaded transactions are insufficient.
        /// </summary>
        [pbr::OriginalName("INSUFFICIENT_TRANSACTIONS")] InsufficientTransactions = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
