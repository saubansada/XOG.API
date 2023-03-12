CREATE view [UserWalletListVW] as 
select 
w.Id,
w.WalletOfUserId UserId,
CASE WHEN w.Amount <= 0 THEN 'Debit' ELSE 'Credit' END TransactionType,
CASE WHEN t.ReturnId IS NULL and t.orderId is null THEN 'System'
when t.ReturnId is null and t.walletid is null then
'Purchased' ELSE 'Returned' END OrderAction, 
t.Id TransactionId,
w.TimeStamp,
CASE WHEN t.ReturnId IS NOT NULL THEN t.ReturnId ELSE t.OrderId END ActionId,
w.Amount Amount from UserWallet w 
left join Transactions t on w.id = t.WalletId
left Join ReturnOrders ro on ro.id = t.ReturnId;