







#import <UIKit/UIKit.h>
#import "MAOverlayRenderer.h"

///该类提供使用CGPathRef来绘制overlay,默认的操作是使用fill attributes, stroke attributes绘制当前path到context中, 可以使用该类的子类MACircleRenderer, MAPolylineRenderer, MAPolygonRenderer或者继承该类, 如果继承该类，需要重载-(void)createPath方法
@interface MAOverlayPathRenderer : MAOverlayRenderer

///填充颜色,默认是[UIColor colorWithRed:0 green:1 blue:0 alpha:0.6]
@property (strong) UIColor *fillColor;

///笔触颜色,默认是[UIColor colorWithRed:1 green:0 blue:0 alpha:0.6]
@property (strong) UIColor *strokeColor;

///笔触宽度,默认是0
@property CGFloat lineWidth;

///LineJoin,默认是kCGLineJoinRound
@property CGLineJoin lineJoin;

///LineCap,默认是kCGLineCapRound
@property CGLineCap lineCap;

///MiterLimit,默认是10.f
@property CGFloat miterLimit;

///LineDashPhase,默认是0.f
@property CGFloat lineDashPhase;

///LineDashPattern,默认是nil
@property (copy) NSArray *lineDashPattern;

///当前的path
@property CGPathRef path;

/**
 * @brief 子类需要重载该方法并设置(self.path = newPath)
 */
- (void)createPath;

/**
 * @brief 释放当前path,调用之后 path == NULL
 */
- (void)invalidatePath;

/**
 * @brief 将当前的stroke attributes设置到指定的context
 * @param context 目标context
 * @param zoomScale 当前缩放比例值
 */
- (void)applyStrokePropertiesToContext:(CGContextRef)context atZoomScale:(MAZoomScale)zoomScale;

/**
 * @brief 将当前的fill attributes设置到指定的context
 * @param context 目标context
 * @param zoomScale 当前缩放比例值
 */
- (void)applyFillPropertiesToContext:(CGContextRef)context atZoomScale:(MAZoomScale)zoomScale;

/**
 * @brief 绘制path
 * @param path 要绘制的path
 * @param context 目标context
 */
- (void)strokePath:(CGPathRef)path inContext:(CGContextRef)context;

/**
 * @brief 填充path
 * @param path 要绘制的path
 * @param context 目标context
 */
- (void)fillPath:(CGPathRef)path inContext:(CGContextRef)context;

@end
