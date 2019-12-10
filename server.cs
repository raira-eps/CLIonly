using System.Configuration;
using System.Data.SqlClient;

public void Connect1()
{
    //接続文字列の取得
    var connectionString = ConfigurationManager.Configuration["sqlsvr"].ConnectionString;

    //データベース接続の準備
    var connection = new SqlConnection(connectionString);

    //データベースの接続開始
    connection.Open();

    //実行するsqlの準備
    var command = new SqlCommand();
    command.Connection = connection;
    command.CommandText = @"SELECT count(*) FROM T_USER" ;

    //SQLの実行
    command.ExecuteNonQuery();

    //データベースの接続終了
    connection.Close();
}