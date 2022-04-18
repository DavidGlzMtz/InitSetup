
# InitSetup

- Ability to create base folders such as root folder _Project
- Inside the _Project folder you would find the following folders:

   - _Scripts

   - Materials

   - Prefabs

   - Scenes

   - Textures

- Adds the script Logging.cs in Inspector components so you can add it to an Empty Object to manage 
  your logs in a better way. Choosing the prefix and color
  of the log and enable the logs itself.

- Example scene are provided in the Package (Tests\Editor\Examples).

## Installation
Copy this [link](https://github.com/DavidGlzMtz/InitSetup.git) on your Package Manager as git url

https://github.com/DavidGlzMtz/InitSetup.git

You can download the *.zip on [GitHub](https://github.com/DavidGlzMtz/InitSetup.git) to add it manually.

![Instalación](https://media2.giphy.com/media/EYx69BG1OQKOMWIVtM/giphy.gif?cid=790b7611ef0c94f53d6d4b4b5637c20520f8a93ee19a0f8e&rid=giphy.gif&ct=g)

## Demo
Add folders.

![Carpetas](https://media2.giphy.com/media/BVqHZkTx45XjNIeOyw/giphy.gif?cid=790b7611ca10d0bb3cc32ae3b9fefb9fba94b4c27dd7431c&rid=giphy.gif&ct=g)

Add the Logging component.

![Componentes](https://media0.giphy.com/media/ADWGaWDD9jWeTMkZ2l/giphy.gif?cid=790b7611acbb3af483acb3ed7133359caab20c48bb89ee92&rid=giphy.gif&ct=g)

Log demo.

![Funcionamiento](https://media4.giphy.com/media/JCETu2NNvOFnbPrmz7/giphy.gif?cid=790b76110c9aacc70b1d797dc10d964dfb3f12e3a663d580&rid=giphy.gif&ct=g)
## Usage/Examples

```csharp
public class Test : MonoBehaviour {
        [Header("Debbuging")]
        [Tooltip("Add de GameObject with the Logging Script")]
        public GameObject SystemLogger;
        private Logger Logger;
        void Start() {
            Logger = SystemLogger.GetComponent<Logger>();
            Logger.Log("This is a System Log", this.gameObject);
        }
    }
}
```


## Authors

- [@DavidGlzMtz](https://www.github.com/DavidGlzMtz)


## Support

For support, email david.a.gonzalez.mtz@gmail.com.


## FAQ

#### Why using underscore '_' ?

Placing underscore before any archive name will place it at the beginning, making it
easier to find it.


## Acknowledgements

 - [Awesome Readme Templates](https://awesomeopensource.com/project/elangosundar/awesome-README-templates)
 - [Awesome README](https://github.com/matiassingers/awesome-readme)
 - [How to write a Good readme](https://bulldogjob.com/news/449-how-to-write-a-good-readme-for-your-github-project)
 - [Jason Storey](https://www.youtube.com/channel/UCG6MguMC0ntGCvVyaEwTPzw)

## License

[MIT](https://choosealicense.com/licenses/mit/)


## Documentation

[Documentation](https://linktodocumentation)

