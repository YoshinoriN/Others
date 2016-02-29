# セットアップ(CentOS7)
---

## SSH設定(サーバー)

OpenSSHがデフォルトでインストールされているため、設定ファイルを変更するだけ。

```sh
# sshd_configをエディタで開く
/etc/ssh/sshd_config

# コメントをなくし、noに変更する
PermitRootLogin no

# 以下2行のコメントをなくす
PermitEmptyPasswords no
PasswordAuthentication yes 
```

sshdを再起動する。
```sh
sudo systemctl restart sshd
```

## ネットワーク設定

CentOS7からはNetworkManagerに付属する「nmtui」コマンドでGUI形式で設定するのが推奨されているらしい。

設定後に「NetworkManager」を再起動する。

```sh
systemctl restart NetworkManager
```