# インストールと開発環境とか

## インストール

### 1.Node.jsをインストールする。
公式のインストーラを使用する。

バージョン確認する。
```js
node -v
```

### 2.TypeScriptをインストールする。
```js
npm install -g typescript
```
バージョン確認する。
```js
tsc -v
```

## 開発環境

* Visual Studio
* Visual Studio Code

## コンパイル

### 1.コマンドプロンプト
コンパイルしたいTypeScriptを指定して「tsc」コマンドを実行する。

```cmd
tsc HelloTypeScript.ts
```

### 2.VSCode
OpenFolderで対象のTypeScriptのコードが入っているディレクトリを指定する。

(これをやらないと、Task Runnerが実行できない)

「Ctrl + Shift + P」でコマンドバーを表示して、「Tasks:Command Runner」を選択。

下記のjsonファイルが表示されるので、「args」にコンパイルしたいtsファイルを指定する。


```json
{
	"version": "0.1.0",

	// The command is tsc. Assumes that tsc has been installed using npm install -g typescript
	"command": "tsc",

	// The command is a shell script
	"isShellCommand": true,

	// Show the output window only if unrecognized errors occur.
	"showOutput": "silent",

	// args is the HelloWorld program to compile.
	"args": ["HelloWorld.ts"],

	// use the standard tsc problem matcher to find compile problems
	// in the output.
	"problemMatcher": "$tsc"
}
```

「Ctrl + Shift + B」でコンパイル実行。(左下でアイコンがくるくる回る)
