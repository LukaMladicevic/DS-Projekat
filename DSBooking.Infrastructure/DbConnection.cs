using System;
using System.Data;
using DSBooking.Infrastructure.Backup;
using DSBooking.Infrastructure.Factory;
using System.Diagnostics; // <-- important

namespace DSBooking.Infrastructure
{
    public class DbConnection
    {
        private static volatile DbConnection? _instance = null;
        private static readonly object _sync = new object();

        private readonly IDbConnection _connection;
        private readonly IDbBackupProvider _backupProvider;

        private DbConnection(IDbConnection connection, IDbBackupProvider backupProvider)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
            _backupProvider = backupProvider ?? throw new ArgumentNullException(nameof(backupProvider));
        }

        public static void Initialize(IDbInfrastructureFactory factory)
        {
            if (factory == null) throw new ArgumentNullException(nameof(factory));

            if (_instance != null)
                throw new InvalidOperationException("DbConnection is already initialized.");

            lock (_sync)
            {
                if (_instance != null)
                    throw new InvalidOperationException("DbConnection is already initialized.");
                //MessageBox.Show("InitFacade konekcija");
                Debug.WriteLine("Before creating connection...");
                IDbConnection connection = factory.CreateConnection();
                Debug.WriteLine("after creating connection...");
                IDbBackupProvider backupProvider = factory.CreateBackupProvider();

                _instance = new DbConnection(connection, backupProvider);
            }
        }

        internal static DbConnection Instance
        {
            get
            {
                if (_instance == null) throw new DbConnectionNotInitializedException();
                return _instance;
            }
        }

        internal IDbConnection Connection => _connection;

        internal IDbBackupProvider BackupProvider => _backupProvider;
    }
}
