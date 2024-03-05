// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com)
//
// Authors:
//	Chris Toshok (toshok@ximian.com)
//

using System;

namespace System.IO.Packaging {

	public class StorageInfo
	{
		internal StorageInfo ()
		{
			throw new NotImplementedException ();
		}

		public string Name {
			get { throw new NotImplementedException (); }
		}

		public StreamInfo CreateStream (string name)
		{
			throw new NotImplementedException ();
		}

		public StreamInfo CreateStream (string name, CompressionOption compressionOption, EncryptionOption encryptionOption)
		{
			throw new NotImplementedException ();
		}

		public StorageInfo CreateSubStorage (string name)
		{
			throw new NotImplementedException ();
		}

		public void DeleteStream (string name)
		{
			throw new NotImplementedException ();
		}

		public void DeleteSubStorage (string name)
		{
			throw new NotImplementedException ();
		}

		public StreamInfo GetStreamInfo (string name)
		{
			throw new NotImplementedException ();
		}

		public StreamInfo[] GetStreams ()
		{
			throw new NotImplementedException ();
		}

		public StorageInfo GetSubStorageInfo (string name)
		{
			throw new NotImplementedException ();
		}

		public StorageInfo[] GetSubStorages ()
		{
			throw new NotImplementedException ();
		}

		public bool StreamExists (string name)
		{
			throw new NotImplementedException ();
		}

		public bool SubStorageExists (string name)
		{
			throw new NotImplementedException ();
		}

	}

}