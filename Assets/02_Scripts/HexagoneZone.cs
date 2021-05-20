using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TestHexagonalPath {

    public class HexagoneZone : MonoBehaviour {

        public GameObject hexGridPrefab;
        public HexCell[] cells;

        float cellDiameter = 10;
        int gridLayers = 12;
        int gridSize;
        int cellCount;
        int pathLength = 40;
        int pathCount;
        GameObject pathGameObject;

        void Start() {
            gridSize++;
            for (int i = 0; i < gridLayers + 1; i++) {
                gridSize += (6 * i);
            }
            Debug.Log("Cells: " + gridSize);
            cells = new HexCell[gridSize];
            cells[0] = new HexCell(Vector3.zero, new int?[6], false);
            for (int i = 0; i < cells.Length; i++) {
                SurroundCellWithNewCells(cells[i], i);
            }
            pathGameObject = new GameObject();
            pathGameObject.transform.parent = transform;
            pathGameObject.name = "Path";
            DrawCells();
            CreatePath();
            DrawPath();
            // StartCoroutine(ShowcaseCoroutine());
        }

        IEnumerator ShowcaseCoroutine() {
            while (true) {
                RegeneratePath();
                yield return new WaitForSeconds(1);
            }
        }

        void CreatePath() {
            pathCount = 0;
            cells[0].occupied = true;
            pathCount++;
            ChooseNextNode(0);
            Debug.Log("PathLength: " + pathCount);
        }

        void RemovePaths() {
            for (int i = 0; i < cells.Length; i++) {
                if (cells[i].occupied) {
                    cells[i].occupied = false;
                }
            }
        }

        void ChooseNextNode(int index) {
            List<int?> list = cells[index].adyacentIndices.ToList<int?>();
            list = Shuffle<int?>(list);
            Stack<int?> adyacents = new Stack<int?>(list);
            for (int i = 0; i < 6; i++) {
                int? randomAdyacentIndex = adyacents.Pop();
                if (randomAdyacentIndex == null) continue;
                if (pathCount < pathLength && !cells[(int)randomAdyacentIndex].occupied) {
                    cells[(int)randomAdyacentIndex].occupied = true;
                    pathCount++;
                    ChooseNextNode((int)randomAdyacentIndex);
                }
            }
        }

        List<T> Shuffle<T>(IList<T> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = UnityEngine.Random.Range(0, n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return (List<T>)list;
        }

        void SurroundCellWithNewCells(HexCell hexCell, int index) {
            Vector3 adyacentCellPosition;
            float angle;
            for (int i = 0; i < 6; i++) {
                if (cellCount + 1 >= gridSize) break;
                angle = ((i * 60) + 30) * Mathf.Deg2Rad;
                adyacentCellPosition = new Vector3((float)Mathf.Sin(angle) * cellDiameter, 0, (float)Mathf.Cos(angle) * cellDiameter) + hexCell.position;
                if (hexCell.adyacentIndices[i] == null) {
                    cellCount++;
                    hexCell.adyacentIndices[i] = cellCount;
                    cells[cellCount] = new HexCell(adyacentCellPosition, new int?[6], false);
                }
            }
            for (int i = 0; i < 6; i++) {
                if (hexCell.adyacentIndices[i] != null) {
                    cells[(int)hexCell.adyacentIndices[i]].adyacentIndices[HexOpposite(i)] = index;
                    if (hexCell.adyacentIndices[HexNext(i)] != null) {
                        cells[(int)hexCell.adyacentIndices[i]].adyacentIndices[HexPrev(HexOpposite(i))] = hexCell.adyacentIndices[HexNext(i)];
                    }
                    if (hexCell.adyacentIndices[HexPrev(i)] != null) {
                        cells[(int)hexCell.adyacentIndices[i]].adyacentIndices[HexNext(HexOpposite(i))] = hexCell.adyacentIndices[HexPrev(i)];
                    }
                }
            }
        }

        int HexPrev(int i) {
            switch (i) {
                case 0: return 5;
                case 1: return 0;
                case 2: return 1;
                case 3: return 2;
                case 4: return 3;
                case 5: return 4;
                default: return 0;
            }
        }

        int HexNext(int i) {
            switch (i) {
                case 0: return 1;
                case 1: return 2;
                case 2: return 3;
                case 3: return 4;
                case 4: return 5;
                case 5: return 0;
                default: return 0;
            }
        }

        int HexOpposite(int i) {
            switch (i) {
                case 0: return 3;
                case 1: return 4;
                case 2: return 5;
                case 3: return 0;
                case 4: return 1;
                case 5: return 2;
                default: return 0;
            }
        }

        void DrawCells() {
            for (int i = 0; i < cells.Length; i++) {
                GameObject cell = Instantiate(hexGridPrefab, cells[i].position, Quaternion.Euler(90, 0, 0), transform);
                cell.transform.localScale = new Vector3(cellDiameter * 0.1f, cellDiameter * 0.1f, 1);
                cell.transform.position = new Vector3(cell.transform.position.x, -1, cell.transform.position.z);
                // cell.name = "C" + UnityEngine.Random.Range(0, 1000000);
                // if (i == 46) {
                //     Debug.Log("Name: " + cell.name);
                //     for (int j = 0; j < 6; j++) {
                //         Debug.Log("Adj" + j + ": " + cells[i].adyacentCells[j].Value.position);
                //     }
                // }
            }
        }

        void DrawPath() {
            for (int i = 0; i < cells.Length; i++) {
                if (cells[i].occupied) {
                    GameObject cell = Instantiate(hexGridPrefab, cells[i].position, Quaternion.Euler(90, 0, 0), pathGameObject.transform);
                    cell.transform.localScale = new Vector3(cellDiameter * 0.1f, cellDiameter * 0.1f, 1);
                }
            }
        }

        public void RegeneratePath() {
            foreach (Transform trans in pathGameObject.transform) {
                Destroy(trans.gameObject);
            }
            RemovePaths();
            pathLength = UnityEngine.Random.Range(10, 61);
            CreatePath();
            DrawPath();
        }

        public struct HexCell {

            public Vector3 position;
            public int?[] adyacentIndices;
            public bool occupied;

            public HexCell(Vector3 _position, int?[] _adyacentCells, bool _occupied) {
                position = _position;
                adyacentIndices = _adyacentCells;
                occupied = _occupied;
            }

        }

    }
}