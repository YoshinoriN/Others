

#### 用途
* gitで過去履歴ごとフォルダ名を一括リネームしたいときにつかう。

#### 使い方
git filter branch で Rubyスクリプトを呼び出す。
```git
git filter-branch --tree-filter

--sample
git filter-branch --tree-filter 'ruby /D/tree-filter-dir.rb　BeforDirName AfterDirName' HEAD --all
```

#### 呼び出すスクリプト
```ruby
require "rake"
require "date"

def main
    puts Time.now
    befordir = ARGV[0]
    afterdir = ARGV[1]
    befordir = befordir.encode("UTF-8", "Shift_JIS")

    if File::directory?(afterdir)
        FileUtils.rm_r(afterdir)
    elsif
        FileUtils.mkdir_p(afterdir)
    end

    if File::directory?(befordir)
        FileUtils.copy_entry(befordir,afterdir)
        FileUtils.rm_r(befordir)
    end
    puts "revision were converted"
    puts Time.now
end
main
```

#### 解説
* ruby スクリプトの第一引数に変更前フォルダ名を指定する。第二引数に変更後フォルダ名を指定する。
* --allで全てのブランチを対象にする。記述していない場合はチェックアウトしているものが対象。
* 各リビジョンで存在しているファイルを取得しないと処理が中断される。例えばHEADでのみ存在しているファイルが有る場合、過去のリビジョンではそのファイルがないため処理が中断される。このため各リビジョンで存在するファイルを取り出すためにrubyスクリプトを使用している。
* rubyスクリプト内では各リビジョンで存在するフォルダおよびファイルを取得して、リネーム後のフォルダにコピーしたあとにもとのフォルダを削除しているだけ。
* ほんとはコピーよりもmvもしくはrenameを使った方が早いが、Windowsだと途中でファイルへのアクセス権限で頻繁に中止されるためにコピー&削除ににした。
* rubyスクリプト内部でフォルダパスをエンコードしているのは移行前のフォルダ名が日本語だったため。

#### 注意点
* git filter-branch --tree-filterはrootディレクトリで実行しないといけない。
* rubyスクリプトは絶対パスを記述する必要がある。

#### その他
* 初めて書くRubyスクリプトなのでたぶんしょぼい
