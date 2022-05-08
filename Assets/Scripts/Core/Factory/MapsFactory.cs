using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;


namespace Core
{
    public class MapsFactory : Factory
    {
        private readonly AllDescriptions _descriptions;
        private Dictionary<int, Task<GameObject>> _dictionary;
        private Vector3 position = new Vector3(0, 0, 0);

        public MapsFactory(AllDescriptions descriptions,  Dictionary<int,Task<GameObject>> dictionary)
        {
            _descriptions = descriptions;
            _dictionary = dictionary;

        }
        
        // нужно определиться с логикой создания карты. Общее поведение примерно такое, но всё же
        public MapsPresenter CreateMaps(int index)
        {
            
            // фабрика получает префаб у Префаб-менеджера
            
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                // todo здесь какая-то логика расстановки зданий
                // todo загрузка префабов тоже должна происходить в отдельном месте (при общей загрузке). И менеджер хранит уже загруженные все префабы
                
                var referenceBuilding = _descriptions.Building.GetView(BuildingType.One);
                position = spawnPoints[i].position;
                CreateObject(referenceBuilding.Result, position);
            }
            
            return new MapsPresenter();
        }
        
    }

    public class Test
    {
       
    }
}