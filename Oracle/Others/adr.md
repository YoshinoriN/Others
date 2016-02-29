# ADR(Automatic Diagnostic Repository:自動診断リポジトリ)

11g以降の機能。

今まで、個別に管理されていたアラートファイル・各種ログを一括管理できるようになった。
従来の「user_dump_dest」「background_dump_dest」は使用されず（項目は存在する）設定しても無効になる。
「DIAG_ADR_ENABLED」を「FALSE」にすることで ADR を無効にすることは可能である。

初期化パラメータ「DIAGNOSTIC_DEST」に「ADR_BASE(ADRのルートディレクトリ)」を設定する。
これはデフォルト値では「ORACLE_BASE」が設定される。
ADRの設定値は「V$DIAG_INFO」で確認することが出来る。
