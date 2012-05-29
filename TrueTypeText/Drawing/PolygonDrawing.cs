using System;
using System.Collections.Generic;
using System.Text;

namespace TrueTypeText.Drawing
{
    /// <summary>
    /// �����
    /// </summary>
    public class PolygonDrawing : IDrawing
    {
        private IList<LineDrawing> lines;

        public PolygonDrawing()
        {
            lines = new List<LineDrawing>();
        }

        /// <summary>
        /// ��ȡ���б�
        /// </summary>
        public IList<LineDrawing> Lines
        {
            get { return lines; }
        }

        #region IDrawing ��Ա

        public virtual void Draw(IDrawingContext context)
        {
            //���߶�
            foreach (IDrawing line in lines)
            {
                line.Draw(context);
            }
        }

        #endregion
    }
}