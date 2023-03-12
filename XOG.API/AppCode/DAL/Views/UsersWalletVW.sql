
CREATE View [UsersWalletVW] AS
Select WalletOfUserId, 
	SUM(CASE WHEN Amount > 0 THEN ABS(Amount) ELSE 0 END) TotalCredited, SUM(CASE WHEN Amount < 0 THEN ABS(Amount) ELSE 0 END) TotalDebited, 
	SUM(Amount) as Amount 
from UserWallet
group by WalletOfUserId;