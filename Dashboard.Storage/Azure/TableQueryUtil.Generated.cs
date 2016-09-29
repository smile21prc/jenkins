using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace Dashboard.Azure
{
    public static partial class TableQueryUtil
    {
        public static string Column(string columnName, byte[] value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterConditionForBinary(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, byte[] value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
        
        public static string Column(string columnName, long value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterConditionForLong(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, long value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
        
        public static string Column(string columnName, bool value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterConditionForBool(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, bool value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
        
        public static string Column(string columnName, int value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterConditionForInt(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, int value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
        
        public static string Column(string columnName, Guid value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterConditionForGuid(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, Guid value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
        
        public static string Column(string columnName, string value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterCondition(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, string value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
        
        public static string Column(string columnName, DateTimeOffset value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterConditionForDate(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, DateTimeOffset value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
        
        public static string Column(string columnName, double value, ColumnOperator op = ColumnOperator.Equal)
        {
            return TableQuery.GenerateFilterConditionForDouble(
                columnName,
                ToQueryComparison(op),
                value);
        }

        public static string Column(ColumnName columnName, double value, ColumnOperator op = ColumnOperator.Equal)
        {
            return Column(ToColumnName(columnName), value, op);
        }
    }
}
