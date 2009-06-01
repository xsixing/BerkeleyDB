using System;
using System.Collections.Generic;
using System.Text;

using BerkeleyDB;

namespace ex_repquote
{
	public class RepQuoteEnvironment
	{
		private bool _appointedClientInit;
		private bool _appFinished;
		private bool _inClientSync;
		private bool _isMaster;
		public DatabaseEnvironment env;

		public bool AppointedClientInit { 
			get { return _appointedClientInit; }
			set { _appointedClientInit = value; }
		}
		public bool AppFinished { 
			get { return _appFinished; }
			set { _appFinished = value; }
		}
		public bool InClientSync { 
			get { return _inClientSync; }
			set { _inClientSync = value; }
		}
		public bool IsMaster { 
			get { return _isMaster; }
			set { _isMaster = value; }
		}

		public static RepQuoteEnvironment Open(string home, DatabaseEnvironmentConfig cfg)
		{
			RepQuoteEnvironment dbEnv = new RepQuoteEnvironment();
			dbEnv.env = DatabaseEnvironment.Open(home, cfg);
			dbEnv._appointedClientInit = false;
			dbEnv._appFinished = false;
			dbEnv._inClientSync = false;
			dbEnv._isMaster = false;
			return dbEnv;
		}
	}
}