using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "GetLbsLifeListRequest")]
	[Serializable]
	public class GetLbsLifeListRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private uint _Opcode;

		private uint _Scene;

		private SKBuiltinBuffer_t _Buff = null;

		private LbsLocation _Loc;

		private string _Keyword = "";

		private uint _EntryTime = 0u;

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

		[ProtoMember(2, IsRequired = true, Name = "Opcode", DataFormat = DataFormat.TwosComplement)]
		public uint Opcode
		{
			get
			{
				return this._Opcode;
			}
			set
			{
				this._Opcode = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "Scene", DataFormat = DataFormat.TwosComplement)]
		public uint Scene
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

		[ProtoMember(4, IsRequired = false, Name = "Buff", DataFormat = DataFormat.Default), DefaultValue(null)]
		public SKBuiltinBuffer_t Buff
		{
			get
			{
				return this._Buff;
			}
			set
			{
				this._Buff = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "Loc", DataFormat = DataFormat.Default)]
		public LbsLocation Loc
		{
			get
			{
				return this._Loc;
			}
			set
			{
				this._Loc = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "Keyword", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Keyword
		{
			get
			{
				return this._Keyword;
			}
			set
			{
				this._Keyword = value;
			}
		}

		[ProtoMember(7, IsRequired = false, Name = "EntryTime", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint EntryTime
		{
			get
			{
				return this._EntryTime;
			}
			set
			{
				this._EntryTime = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
