using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "SyncRequest")]
	[Serializable]
	public class SyncRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private SKBuiltinString_t _UserName;

		private uint _SyncKey;

		private int _Scene;

		private int _Option;

		private CmdList _Oplog;

		private string _KeyBuf = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "UserName", DataFormat = DataFormat.Default)]
		public SKBuiltinString_t UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				this._UserName = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "SyncKey", DataFormat = DataFormat.TwosComplement)]
		public uint SyncKey
		{
			get
			{
				return this._SyncKey;
			}
			set
			{
				this._SyncKey = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "Scene", DataFormat = DataFormat.TwosComplement)]
		public int Scene
		{
			get
			{
				return this._Scene;
			}
			set
			{
				this._Scene = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "Option", DataFormat = DataFormat.TwosComplement)]
		public int Option
		{
			get
			{
				return this._Option;
			}
			set
			{
				this._Option = value;
			}
		}

		[ProtoMember(6, IsRequired = true, Name = "Oplog", DataFormat = DataFormat.Default)]
		public CmdList Oplog
		{
			get
			{
				return this._Oplog;
			}
			set
			{
				this._Oplog = value;
			}
		}

		[ProtoMember(7, IsRequired = false, Name = "KeyBuf", DataFormat = DataFormat.Default), DefaultValue("")]
		public string KeyBuf
		{
			get
			{
				return this._KeyBuf;
			}
			set
			{
				this._KeyBuf = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
